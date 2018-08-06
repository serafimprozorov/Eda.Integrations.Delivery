using System;

using Microsoft.Extensions.DependencyInjection;


namespace Eda.Integrations.Delivery.DependencyInjection
{
    /// <summary>
    /// The collection of delivery services.
    /// </summary>
    public class DeliveryServiceCollection
    {
        
        
        
        
        #region Dependencies
        
        private readonly IServiceCollection _serviceCollections;

        #endregion

        #region Constructor
        
        internal DeliveryServiceCollection(IServiceCollection serviceCollections) =>
            _serviceCollections = serviceCollections;

        #endregion
        
        #region Methods

        /// <summary>
        /// Adds the delivery service block.
        /// </summary>
        /// <typeparam name="TDeliveryServiceBlock">The block type.</typeparam>
        public DeliveryServiceCollection AddService<TDeliveryServiceBlock>()
            where TDeliveryServiceBlock : DeliveryServiceApplicationBlock =>
            AddService(Activator.CreateInstance<TDeliveryServiceBlock>());


        /// <summary>
        /// Adds the <paramref name="block"/>.
        /// </summary>
        /// <param name="block">The delivery service block.</param>
        public DeliveryServiceCollection AddService(DeliveryServiceApplicationBlock block)
        {
            block.AddTo(_serviceCollections);
            return this;
        }
        
        #endregion
    }
}