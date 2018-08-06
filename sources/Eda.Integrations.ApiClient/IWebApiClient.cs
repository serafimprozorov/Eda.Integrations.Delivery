using System;

namespace Eda.Integrations.ApiClient
{
    public interface IWebApiClient : IDisposable
    {
        IWebApiRequest Request(string url);
    }
}