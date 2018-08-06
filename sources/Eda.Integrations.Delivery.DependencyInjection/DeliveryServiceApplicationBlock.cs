using System;

using Microsoft.Extensions.DependencyInjection;

using Eda.Extensions.DependencyInjection;


namespace Eda.Integrations.Delivery.DependencyInjection
{
    /// <inheritdoc />
    /// <summary>
    /// Base class for delivery service block.
    /// </summary>
    public abstract class DeliveryServiceApplicationBlock : IApplicationBlock
    {
        public void AddTo(IServiceCollection services) => services
            .AddSingleton(CreateFactory)
            .AddSingleton(CreateGeoService)
            .AddSingleton(CreateDeliveryService);


        protected abstract void AddFactory(IServiceCollection services) => services.Add()

        protected abstract void AddGeoService(IServiceCollection services);
        
        protected abstract void AddDeliveryService(IServiceCollection services);
    }
}