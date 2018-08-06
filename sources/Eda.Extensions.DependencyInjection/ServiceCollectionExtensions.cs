using System;

using Microsoft.Extensions.DependencyInjection;


namespace Eda.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions for Microsoft Dependency Injection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the application block to the service collection.
        /// </summary>
        /// <param name="this">The service collection.</param>
        /// <typeparam name="TBlock">The application block type.</typeparam>
        public static IServiceCollection AddBlock<TBlock>(this IServiceCollection @this)
            // ReSharper disable once HeapView.BoxingAllocation    
            where TBlock : IApplicationBlock => @this.AddBlock(Activator.CreateInstance<TBlock>());


        /// <summary>
        /// Adds the <see cref="block"/> to the servces collection.
        /// </summary>
        /// <param name="this">The service collection.</param>
        /// <param name="block">The block instance.</param>
        public static IServiceCollection AddBlock(this IServiceCollection @this, IApplicationBlock block)
        {
            block.AddTo(@this);
            return @this;
        }
    }
}