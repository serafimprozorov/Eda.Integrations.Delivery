namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The contract for the delivery service provider.
    /// </summary>
    public interface IDeliveryServiceProvider
    {
        /// <summary>
        /// Gets the delivery service provider.
        /// </summary>
        /// <param name="systemName">The system name.</param>
        IDeliveryService GetDeliveryService(string systemName);
    }
}