namespace Eda.Integrations.Delivery
{
    /// <inheritdoc cref="INamedObject" />
    /// <summary>
    /// The city data contract.
    /// </summary>
    public interface ICity : IGeography, INamedObject
    {
        /// <summary>
        /// Gets the region.
        /// </summary>
        IRegion Region { get; }
    }
}