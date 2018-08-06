namespace Eda.Integrations.Delivery.Contracts
{
    /// <summary>
    /// The data contract for geography objects.
    /// </summary>
    public interface IGeography
    {
        /// <summary>
        /// Gets the latitude.
        /// </summary>
        double Latitude { get; }
        
        /// <summary>
        /// Gets the longitude.
        /// </summary>
        double Longitude { get; }
    }
}