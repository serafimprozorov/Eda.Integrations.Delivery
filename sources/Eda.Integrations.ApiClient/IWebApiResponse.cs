namespace Eda.Integrations.ApiClient
{
    public interface IWebApiResponse
    {
        int StatusCode { get; }
        
        string StatusMessage { get; }
        
        object Headers { get; }
        
        object Cookies { get; }
    }
}