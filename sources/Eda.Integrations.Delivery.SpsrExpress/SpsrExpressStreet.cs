using System.Collections.Generic;
using System.Globalization;

namespace Eda.Integrations.Delivery.SpsrExpress
{
    /// <summary>
    /// The data contract for the SPSR Express street object.
    /// </summary>
    public class SpsrExpressStreet : IStreet
    {
        #region Fields
        
        private readonly IReadOnlyDictionary<CultureInfo, string> _names;
        
        #endregion
        
        #region Constructor

        internal SpsrExpressStreet(object id, ICity city, IReadOnlyDictionary<CultureInfo, string> names,
            double latitude, double longitude)
        {
            _names = names;
            Id = id;
            City = city;
        }
        
        #endregion

        #region IObject
        
        public object Id { get; }
        
        #endregion
        
        #region INamedObject
        
        public string GetName(CultureInfo culture) => 
        {
            throw new System.NotImplementedException();
        }
        
        #endregion

        public double Latitude { get; }
        public double Longitude { get; }
        public ICity City { get; }
    }
}