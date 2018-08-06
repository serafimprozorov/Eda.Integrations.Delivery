namespace Eda.Integrations.Delivery.Contracts
{
    /// <summary>
    /// The data contract for delivery information.
    /// </summary>
    public interface IDeliveryInformation
    {
        #region Properties
        
        /// <summary>
        /// Gets the delivery request.
        /// </summary>
        IDeliveryRequest Request { get; }
        
        
        /// <summary>
        /// Gets the delivery cost.
        /// </summary>
        decimal Cost { get; }
        
        #endregion
    }
}