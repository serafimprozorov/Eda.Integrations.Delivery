using System;
using System.Collections.Generic;

namespace Eda.Integrations.ApiClient
{
    internal class WebApiClientFactory : IWebApiClientFactory
    {
        private readonly IHttpClientProvider _httpClientProvider;
        private readonly IDictionary<string, WebApiClientOptions> _optionsMap;
        
             
        public WebApiClientFactory(IHttpClientProvider httpClientProvider) => _httpClientProvider = httpClientProvider;
        
        
        public WebApiClient CreateClient(string name)
        {
            var httpClient = _httpClientProvider.CreateHttpClient(name);
            var options = _optionsMap.TryGetValue(name, out var result) ? result : WebApiClientOptions.Default;

            return new WebApiClient(httpClient, options);
        }
    }
}