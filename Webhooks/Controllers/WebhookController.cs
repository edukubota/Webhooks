using Microsoft.AspNetCore.Mvc;
using Webhooks.Services;

namespace Webhooks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly WebhookService _webhookService;

        public WebhookController(WebhookService webhookService)
        {
            _webhookService = webhookService;
        }

        [HttpPost("publish")]
        public async Task<IActionResult> PublishMessage([FromBody] PublishRequest request)
        {
            await _webhookService.PublishMessage(request.Topic, request.Message);
            return Ok("Message published");
        }
    }
}
