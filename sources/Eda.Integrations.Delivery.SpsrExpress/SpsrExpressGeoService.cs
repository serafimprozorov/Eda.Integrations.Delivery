using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    public class SpsrExpressGeoService : IDeliveryGeoService
    {
        public Task<IReadOnlyList<ICountry>> GetCountries(string start, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<IRegion>> GetRegions(ICountry country, string start, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<ICity>> GetCities(IRegion region, string start, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<IStreet>> GetStreets(ICity city, string start, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }
    }
}