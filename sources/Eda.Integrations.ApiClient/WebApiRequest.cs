using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Eda.Integrations.ApiClient
{
    internal class WebApiRequest : IWebApiRequest
    {
        private readonly HttpClient _httpClient;


        public WebApiRequest(string url, HttpClient httpClient)
        {
            Url = url;
            _httpClient = httpClient;
        }
        
        public string Url { get; }
        public IDictionary<string, object> QueryString { get; }
        public IDictionary<string, IReadOnlyCollection<string>> Headers { get; }
        public IDictionary<string, string> Cookies { get; }
        

        public object Body { get; set; }


        private string CreateQueryString()
        {
            var values = string.Join("&", QueryString.Select(kvp => $"{kvp.Key}={kvp.Value.ToString()}"));
            return values.Length == 0 ? "" : $"?{values}";
        }

        private string CreateUrl() => $"{Url}{CreateQueryString()}";

        private HttpRequestMessage CreateHttpRequest(HttpMethod method)
        {
            
        }

        private T HandleResponse<T>(HttpResponseMessage response) where T : IWebApiResponse
        {
            
        }
        
        
        public async Task<IGetWebApiResponse> Get(CancellationToken ct = default)
        {
            if (Body != null)
                throw new InvalidOperationException("Cant't send body with GET method.");

            return HandleResponse<IGetWebApiResponse>(
                await _httpClient.SendAsync(CreateHttpRequest(HttpMethod.Get), ct));
        }

        public async Task<IHeadWebApiResponse> Head(CancellationToken ct = default)
        {
            if (Body != null)
                throw new InvalidOperationException("Cant't send body with HEAD method.");
            
            return HandleResponse<IHeadWebApiResponse>(
                await _httpClient.SendAsync(CreateHttpRequest(HttpMethod.Head), ct));
        }

        public async Task<IPostWebApiResponse> Post(CancellationToken ct = default) =>
            HandleResponse<IPostWebApiResponse>(await _httpClient.SendAsync(CreateHttpRequest(HttpMethod.Post), ct));

        public async Task<IPutWebApiResponse> Put(CancellationToken ct = default) =>
            HandleResponse<IPutWebApiResponse>(await _httpClient.SendAsync(CreateHttpRequest(HttpMethod.Put), ct));

        public async Task<IDeleteWebApiResponse> Delete(CancellationToken ct = default)
        {
            if (Body != null)
                throw new InvalidOperationException("Cant't send body with DELETE method.");

            return HandleResponse<IDeleteWebApiResponse>(
                await _httpClient.SendAsync(CreateHttpRequest(HttpMethod.Delete), ct));
        }

        public async Task<IOptionsWebApiResponse> Options(CancellationToken ct = default)
        {
            if (Body != null)
                throw new InvalidOperationException("Cant't send body with OPTIONS method.");
            
            return HandleResponse<IOptionsWebApiResponse>(
                await _httpClient.SendAsync(CreateHttpRequest(HttpMethod.Options), ct));
        }

        public async Task<ITraceWebApiResponse> Trace(CancellationToken ct = default) =>
            HandleResponse<ITraceWebApiResponse>(await _httpClient.SendAsync(CreateHttpRequest(HttpMethod.Trace), ct));
    }
}