using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

public class RabbitMQBackgroundService : BackgroundService
{
    private readonly ILogger<RabbitMQBackgroundService> _logger;
    private IConnection _connection;
    private IChannel _channel;

    public object BroadcastMessage { get; private set; }

    public RabbitMQBackgroundService(ILogger<RabbitMQBackgroundService> logger)
    {
        _logger = logger;
    }


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };

        _connection = await factory.CreateConnectionAsync();
        _channel = await _connection.CreateChannelAsync();
        await _channel.QueueDeclareAsync(queue: "hub_queue",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

        _logger.LogInformation("RabbitMQ connection established.");



        var consumer = new AsyncEventingBasicConsumer(_channel);
        consumer.ReceivedAsync += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            _logger.LogInformation($"Received: {message}");
        };


        await _channel.BasicConsumeAsync(queue: "hub_queue",
                                autoAck: true,
                                consumer: consumer);

        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(1000, stoppingToken); // منتظر ماندن برای جلوگیری از مصرف CPU بالا
        }
        stoppingToken.Register(() =>
        {
            _channel.CloseAsync();
            _connection.CloseAsync();
            _logger.LogInformation("RabbitMQ connection closed.");
        });
    }

    public override void Dispose()
    {
        _channel?.CloseAsync();
        _connection?.CloseAsync();
        base.Dispose();
    }
}