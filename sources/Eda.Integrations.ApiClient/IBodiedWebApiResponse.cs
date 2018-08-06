namespace Eda.Integrations.ApiClient
{
    public interface IBodiedWebApiResponse : IWebApiResponse
    {
        object Body { get; }
    }
}