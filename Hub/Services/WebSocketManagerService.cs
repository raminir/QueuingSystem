using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;

public class WebSocketManager
{
    private static ConcurrentDictionary<string, WebSocket> _clients = new();

    public async Task HandleWebSocket(HttpContext context)
    {
        if (!context.WebSockets.IsWebSocketRequest)
        {
            context.Response.StatusCode = 400;
            return;
        }

        using var webSocket = await context.WebSockets.AcceptWebSocketAsync();
        string clientId = Guid.NewGuid().ToString();
        _clients.TryAdd(clientId, webSocket);

        var buffer = new byte[1024 * 4];
        while (webSocket.State == WebSocketState.Open)
        {
            var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            if (result.MessageType == WebSocketMessageType.Text)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                Console.WriteLine($"Client [{clientId}] Sent: {message}");
            }
            else if (result.MessageType == WebSocketMessageType.Close)
            {
                break;
            }
        }

        _clients.TryRemove(clientId, out _);
        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by client", CancellationToken.None);
    }

    public async Task BroadcastMessage(string message)
    {
        var bytes = Encoding.UTF8.GetBytes(message);
        foreach (var client in _clients.Values)
        {
            if (client.State == WebSocketState.Open)
            {
                await client.SendAsync(new ArraySegment<byte>(bytes, 0, bytes.Length), WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }
    }
}
