namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The data contract for delivery information.
    /// </summary>
    public interface IDeliveryInformation
    {
        /// <summary>
        /// Gets the delivery request.
        /// </summary>
        IDeliveryRequest Request { get; }
        
        
        /// <summary>
        /// Gets the delivery cost.
        /// </summary>
        decimal Cost { get; }
        
        /// <summary>
        /// Gets the currency.
        /// </summary>
        object Currency { get; }
    }
}