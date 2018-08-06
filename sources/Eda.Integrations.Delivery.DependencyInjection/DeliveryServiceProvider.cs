using System;
using Microsoft.Extensions.DependencyInjection;

namespace Eda.Integrations.Delivery.DependencyInjection
{
    internal class DeliveryServiceProvider : IDeliveryServiceProvider
    {
        private readonly IServiceProvider _serviceProvider;


        public DeliveryServiceProvider(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;


        public IDeliveryService GetDeliveryService(string systemName) => _serviceProvider
            .GetService<IDeliveryServiceProvider>()
            .GetDeliveryService(systemName);
    }
}