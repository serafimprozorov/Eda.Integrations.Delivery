using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Eda.Integrations.Delivery.Contracts
{
    public interface IDeliveryGeoService
    {
        Task<IReadOnlyList<ICountry>> GetCountries(string start, CancellationToken ct = default);

        Task<IReadOnlyList<IRegion>> GetRegions(ICountry country, string start, CancellationToken ct = default);
        
        Task<IReadOnlyList<ICity>> GetCities(IRegion region, string start,
            CancellationToken ct = default);

        Task<IReadOnlyList<IStreet>> GetStreets(ICity city, string start, CancellationToken ct = default);
    }
}