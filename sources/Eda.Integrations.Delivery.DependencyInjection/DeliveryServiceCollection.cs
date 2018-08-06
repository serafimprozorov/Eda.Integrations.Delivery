using System;
using System.Collections;
using System.Collections.Generic;
using Eda.Integrations.Delivery.Contracts;

namespace Eda.Integrations.Delivery.DependencyInjection
{
    internal class DeliveryServiceCollection : IDeliveryServiceCollection, IDeliveryServiceProvider
    {
        private readonly IDictionary<string, Type> _typeMap = new Dictionary<string, Type>();
        private readonly IServiceProvider _serviceProvider;


        public DeliveryServiceCollection(IServiceProvider serviceProvider) =>
            _serviceProvider = serviceProvider;
        

        #region IEnumerable
        
        public IEnumerator<KeyValuePair<string, Type>> GetEnumerator() => _typeMap.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        #region IDeliveryServiceCollection

        public IDeliveryServiceCollection Clear()
        {
            _typeMap.Clear();
            return this;
        }

        public IDeliveryServiceCollection AddService<TDeliveryService>(string systemName = null) where TDeliveryService : IDeliveryService
        {
            _typeMap[systemName ?? typeof(TDeliveryService).Name] = typeof(TDeliveryService);
            return this;
        }
        
        #endregion

        #region IDeliveryServiceProvider
        
        public IDeliveryService GetDeliveryService(string name)
        {
            if (!_typeMap.TryGetValue(name, out var type))
                throw new Exception();

            if (!(_serviceProvider.GetService(type) is IDeliveryService instance))
                throw new Exception();

            return instance;
        }
        
        #endregion
    }
}