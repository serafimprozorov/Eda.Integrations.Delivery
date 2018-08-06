using System.Net.Http;

namespace Eda.Integrations.ApiClient
{
    public interface IHttpClientProvider
    {
        HttpClient CreateHttpClient(string name);
    }
}