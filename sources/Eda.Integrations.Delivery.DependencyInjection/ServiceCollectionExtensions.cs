using Microsoft.Extensions.DependencyInjection;

namespace Eda.Integrations.Delivery.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IDeliveryServiceCollection AddDelivery(this IServiceCollection @this)
        {
            DeliveryServiceCollection deliveryServices = null;
            
            @this.AddSingleton<IDeliveryServiceProvider, DeliveryServiceCollection>(services =>
            {
                deliveryServices = new DeliveryServiceCollection(services);
                return deliveryServices;
            });
            
            return deliveryServices;
        }
    }
}