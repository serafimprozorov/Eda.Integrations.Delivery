using Eda.Extensions.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;


namespace Eda.Integrations.Delivery.DependencyInjection
{
    /// <summary>
    /// Contains <see cref="IServiceCollection"/> extensions for adding delivery.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the delivery.
        /// </summary>
        /// <param name="this">The service collection.</param>
        /// <typeparam name="TDeliveryApplicationBlock">The application block type.</typeparam>
        public static IServiceCollection AddDelivery<TDeliveryApplicationBlock>(this IServiceCollection @this)
            where TDeliveryApplicationBlock : DeliveryApplicationBlock
        {
            @this.AddBlock<TDeliveryApplicationBlock>();
            return @this;
        }


        /// <summary>
        /// Adds the delivery.
        /// </summary>
        /// <param name="this">The service collection.</param>
        /// <param name="block">The block.</param>
        public static IServiceCollection AddDelivery(this IServiceCollection @this, DeliveryApplicationBlock block)
        {
            @this.AddBlock(block);
            return @this;
        }
    }
}