namespace Eda.Integrations.Delivery.Contracts
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for the region.
    /// </summary>
    public interface IRegion : INamedObject
    {
        /// <summary>
        /// Gets the country.
        /// </summary>
        ICountry Country { get; }
    }
}