using RabbitMQ.Client;
using System.Text;

namespace QueuingSystem.Services.Queuing.Infrastructure.Application.Services
{
    public class SendChangeStatusMessage
    {
        public async void SendMessageToHub(string message)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: "hub_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);
            var body = Encoding.UTF8.GetBytes(message);
            await channel.BasicPublishAsync(exchange: "", routingKey: "hub_queue", body: body);
        }
        public async void send2()
        {

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection =  await factory.CreateConnectionAsync())
            using (var channel = await  connection.CreateChannelAsync())
            {
                await  channel.QueueDeclareAsync(queue: "testQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);

                string message = "Hello RabbitMQ!";
                var body = Encoding.UTF8.GetBytes(message);

                await  channel.BasicPublishAsync(exchange: "", routingKey: "testQueue", body: body);
                Console.WriteLine($"[x] Sent {message}");
            }
        }
    }
}
