using Microsoft.Extensions.DependencyInjection;

using Eda.Extensions.DependencyInjection;


namespace Eda.Integrations.Delivery.DependencyInjection
{
    /// <inheritdoc />
    /// <summary>
    /// Base class for delivery application block.
    /// </summary>
    public abstract class DeliveryApplicationBlock : IApplicationBlock
    {
        #region IApplicationBlock
        
        /// <inheritdoc />
        public void AddTo(IServiceCollection services)
        {
            var deliveryServices = new DeliveryServiceCollection(services);
            
            ConfigureDeliveryServices(deliveryServices);

            services.AddSingleton(serviceProvider => new DeliveryServiceProvider(serviceProvider));
        }
        
        #endregion
        
        #region Methods

        /// <summary>
        /// Configures selivery services.
        /// </summary>
        /// <param name="services">Delivery services collection.</param>
        protected abstract void ConfigureDeliveryServices(DeliveryServiceCollection services);
        
        #endregion
    }
}