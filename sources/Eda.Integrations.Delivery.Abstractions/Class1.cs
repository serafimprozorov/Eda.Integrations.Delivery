using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Eda.Integrations.Delivery.Contracts;
using Eda.Integrations.Delivery.DependencyInjection;

namespace Eda.Integrations.Delivery.Abstractions
{
    public abstract class DeliveryServiceBase : IDeliveryService
    {
        public IDeliveryServiceFactory Factory { get; }
        
        
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