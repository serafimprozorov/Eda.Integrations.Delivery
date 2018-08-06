using System.Globalization;


namespace Eda.Integrations.Delivery
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for the country.
    /// </summary>
    public interface ICountry : INamedObject
    {
        /// <summary>
        /// Gets the country culture.
        /// </summary>
        CultureInfo Culture { get; }
        
        
        /// <summary>
        /// Gets the country currency.
        /// Not used now.
        /// </summary>
        object Currency { get; }
    }
}