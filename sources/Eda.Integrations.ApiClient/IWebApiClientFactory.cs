namespace Eda.Integrations.ApiClient
{
    public interface IWebApiClientFactory
    {
        WebApiClient CreateClient(string name);
    }
}