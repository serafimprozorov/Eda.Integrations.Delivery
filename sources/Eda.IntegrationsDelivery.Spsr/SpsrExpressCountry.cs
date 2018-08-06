using System.Collections.Generic;
using System.Globalization;
using Eda.Integrations.Delivery.Contracts;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    internal class SpsrExpressCountry : NamedObjectBase, ICountry
    {
        public SpsrExpressCountry(object id, IReadOnlyDictionary<CultureInfo, string> names, string invariantCultureName, CultureInfo culture,
            IReadOnlyCollection<ICity> cities, object currency) : base(names, invariantCultureName)
        {
            Id = id;
            Culture = culture;
            Cities = cities;
            Currency = currency;
        }
        
        
        public object Id { get; }
        
        public CultureInfo Culture { get; }

        public IReadOnlyCollection<ICity> Cities { get; }
        
        public object Currency { get; }
    }
}