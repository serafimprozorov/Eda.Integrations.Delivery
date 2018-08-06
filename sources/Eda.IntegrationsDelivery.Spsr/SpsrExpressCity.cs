using System.Collections.Generic;
using System.Globalization;
using Eda.Integrations.Delivery.Contracts;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    internal class SpsrExpressCity : NamedObjectBase, ICity
    {
        public double Latitude { get; }
        
        public double Longitude { get; }
        
        public object Id { get; }
        
        public IReadOnlyCollection<IPickupPoint> PickupPoints { get; }

        public SpsrExpressCity(object id, double latitude, double longitude,
            IReadOnlyDictionary<CultureInfo, string> names, string invariantCultureName,
            IReadOnlyCollection<IPickupPoint> pickupPoints) : base(names, invariantCultureName)
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
            PickupPoints = pickupPoints;
        }
    }
}