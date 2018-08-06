using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Eda.Integrations.ApiClient;
using Eda.Integrations.Delivery.Contracts;
using Eda.Integrations.Delivery.DependencyInjection;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    internal class SpsrExpressDeliveryService : IDeliveryService, IDeliveryGeoService
    {
        private readonly IWebApiClient _webApiClient;
        private readonly string _userAgent;


        public SpsrExpressDeliveryService(IWebApiClientFactory webApiClientFactory)
        {
            _webApiClient = webApiClientFactory.CreateClient(nameof(SpsrExpressDeliveryService));
            Factory = new SpsrExpressFactory();
        }
        
        
        
        public IDeliveryServiceFactory Factory { get; }



        public async Task<IDeliveryInformation> GetDeliveryInformation(IDeliveryRequest deliveryRequest,
            CancellationToken ct = default)
        {
            var request = new CalculatorRequest(deliveryRequest.SourceAddress.City,
                deliveryRequest.DestinationAddress.City, deliveryRequest.Parcel.Weight, deliveryRequest.Parcel.Type);

            var response = await _webApiClient
                .Request(request.Url)
                .WithQueryString(request.ToQueryString())
                .Get();

            return new SpsrExpressDeliveryInformation(reponse);
        }

        
        public Task<IDelivery> CreateDelivery(IDeliveryRequest request, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        
        public Task<IDeliveryOrder> GetDeliveryOrder(IDelivery delivery, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        
        public Task<string> GetDeliveryTrackingNumber(IDeliveryOrder order, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }




        public async Task<IReadOnlyList<ICountry>> GetCountries(string start, CancellationToken ct = default) =>
            (await GetCities(null, "", ct)).Select(c => c.Country).Distinct(CountryEqualityComparer.Instance).ToArray();


        public async Task<IReadOnlyList<IRegion>>
            GetRegions(ICountry country, string start, CancellationToken ct = default) =>
            (await GetCities(null, "", ct)).Select(c => c.Region).Distinct(RegionEqualityComparer.Instance).ToArray();

        
        public async Task<IReadOnlyList<ICity>> GetCities(IRegion region, string start, CancellationToken ct = default)
        {
            var request = new CitiesRequest(start);

            //TODO: Aggressive caching.
            
            var response = await _webApiClient
                .Request(request.Url)
                .WithQueryParameter("", "")
                .WithUserAgent(_userAgent)
                .WithHeader("", "")
                .WithBody(request.ToXml())
                .Post();

            return new CitiesResponse(response);
        }

        
        public async Task<IReadOnlyList<IStreet>> GetStreets(ICity city, string start, CancellationToken ct = default)
        {
            var request = new StreetsRequest(start);
            
            // TODO: Aggressive caching;

            var response = await _webApiClient
                .Request(request.Url)
                .WithQueryParameter("", "")
                .WithUserAgent(_userAgent)
                .WithHeader("", "")
                .WithBody(request.ToXml())
                .Post();

            return new StreetsResponse(response);
        }
    }

    internal class CountryEqualityComparer : IEqualityComparer<ICountry>
    {
        public static readonly CountryEqualityComparer Instance = new CountryEqualityComparer();
        
        
        public bool Equals(ICountry x, ICountry y)
        {
            throw new System.NotImplementedException();
        }

        public int GetHashCode(ICountry obj)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class RegionEqualityComparer : IEqualityComparer<IRegion>
    {
        public static readonly RegionEqualityComparer Instance = new RegionEqualityComparer();
        
        public bool Equals(IRegion x, IRegion y)
        {
            throw new System.NotImplementedException();
        }

        public int GetHashCode(IRegion obj)
        {
            throw new System.NotImplementedException();
        }
    }
    
    internal interface IBodySerializer
    {
    }
}