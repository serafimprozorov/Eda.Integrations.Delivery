namespace Eda.Integrations.Delivery.Contracts
{
    /// <inheritdoc cref="INamedObject" />
    /// <summary>
    /// The city data contract.
    /// </summary>
    public interface ICity : IGeography, INamedObject
    {
        #region Properties
        
        /// <summary>
        /// Gets the region.
        /// </summary>
        IRegion Region { get; }
        
        
        /// <summary>
        /// Gets the country.
        /// </summary>
        ICountry Country { get; }
        
        #endregion
    }
}