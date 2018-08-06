using System;
using System.Net.Http;

namespace Eda.Integrations.ApiClient
{
    public class WebApiClient : IWebApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly WebApiClientOptions _options;


        public WebApiClient(HttpClient httpClient, WebApiClientOptions options)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _options = options ?? throw new ArgumentNullException(nameof(options));
        }


        public IWebApiRequest Request(string url) => new WebApiRequest(url, _httpClient);


        public void Dispose() => _httpClient?.Dispose();
    }


    public interface IGetWebApiResponse : IBodiedWebApiResponse
    {
        
    }

    public interface IHeadWebApiResponse : IWebApiResponse
    {
        
    }

    public interface IPostWebApiResponse : IBodiedWebApiResponse
    {
        
    }

    public interface IPutWebApiResponse : IBodiedWebApiResponse
    {
        
    }

    public interface IDeleteWebApiResponse : IBodiedWebApiResponse
    {
        
    }

    public interface IOptionsWebApiResponse : IWebApiResponse
    {
        
    }

    public interface ITraceWebApiResponse : IBodiedWebApiResponse
    {
        
    }
}