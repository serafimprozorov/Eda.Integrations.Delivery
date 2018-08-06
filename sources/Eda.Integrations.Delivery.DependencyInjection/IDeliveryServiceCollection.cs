using System;
using System.Collections.Generic;
using Eda.Integrations.Delivery.Contracts;

namespace Eda.Integrations.Delivery.DependencyInjection
{
    public interface IDeliveryServiceCollection : IEnumerable<KeyValuePair<string, Type>>
    {
        IDeliveryServiceCollection Clear();

        IDeliveryServiceCollection AddService<TDeliveryService>(string systemName = null) where TDeliveryService : IDeliveryService;
    }
}