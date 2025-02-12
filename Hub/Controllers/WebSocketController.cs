using Microsoft.AspNetCore.Mvc;

[Route("WebSocket")]
[ApiController]
public class WebSocketController : ControllerBase
{
    private readonly WebSocketManager _webSocketManager;

    public WebSocketController(WebSocketManager webSocketManager)
    {
        _webSocketManager = webSocketManager;
    }

    [HttpGet]
    public async Task Get()
    {
        await _webSocketManager.BroadcastMessage("asdasdasdsssssssssss");
    }
}
