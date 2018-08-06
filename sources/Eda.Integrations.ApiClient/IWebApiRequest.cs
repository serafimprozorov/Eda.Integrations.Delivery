using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Eda.Integrations.ApiClient
{
    public interface IWebApiRequest
    {
        
        string Url { get; }
        
        IDictionary<string, object> QueryString { get; }
        
        IDictionary<string, IReadOnlyCollection<string>> Headers { get; }
        
        IDictionary<string, string> Cookies { get; }
        
        object Body { get; set; }



        Task<IGetWebApiResponse> Get(CancellationToken ct = default);

        Task<IHeadWebApiResponse> Head(CancellationToken ct = default);

        Task<IPostWebApiResponse> Post(CancellationToken ct = default);

        Task<IPutWebApiResponse> Put(CancellationToken ct = default);

        Task<IDeleteWebApiResponse> Delete(CancellationToken ct = default);

        Task<IOptionsWebApiResponse> Options(CancellationToken ct = default);

        Task<ITraceWebApiResponse> Trace(CancellationToken ct = default);
    }
}