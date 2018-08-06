using System.Threading;
using System.Threading.Tasks;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    public class SpsrExpressDeliveryService : IDeliveryService
    {
        public IDeliveryServiceFactory Factory { get; }
        public IDeliveryGeoService GeoService { get; }

        public Task<IDeliveryInformation> GetDeliveryInformation(IDeliveryRequest request, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
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
    }
}