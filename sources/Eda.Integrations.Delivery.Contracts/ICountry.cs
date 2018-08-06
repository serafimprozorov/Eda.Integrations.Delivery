using System.Globalization;


namespace Eda.Integrations.Delivery.Contracts
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for the country.
    /// </summary>
    public interface ICountry : INamedObject
    {
        #region Properties
        
        /// <summary>
        /// Gets the country culture.
        /// </summary>
        CultureInfo Culture { get; }
        
        
        /// <summary>
        /// Gets the country currency.
        /// Not used now.
        /// </summary>
        object Currency { get; }
        
        #endregion
    }
}