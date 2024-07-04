namespace Webhooks.Services
{
    public record PublishRequest(string Topic, object Message);
}
