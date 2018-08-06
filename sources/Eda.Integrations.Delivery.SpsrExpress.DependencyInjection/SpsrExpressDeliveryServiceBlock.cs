using System;

using Eda.Integrations.Delivery.DependencyInjection;


namespace Eda.Integrations.Delivery.SpsrExpress.DependencyInjection
{
    public class SpsrExpressDeliveryServiceBlock : DeliveryServiceApplicationBlock
    {
        protected override IDeliveryServiceFactory CreateFactory(IServiceProvider services) => new Spsr
        {
            throw new NotImplementedException();
        }

        protected override IDeliveryGeoService CreateGeoService(IServiceProvider services)
        {
            throw new NotImplementedException();
        }

        protected override IDeliveryService CreateDeliveryService(IServiceProvider services)
        {
            throw new NotImplementedException();
        }
    }
}