namespace Eda.Integrations.Delivery.Contracts
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for delivery order.
    /// </summary>
    public interface IDeliveryOrder : IObject
    {
        #region Properties
        
        /// <summary>
        /// Gets the delivery.
        /// </summary>
        IDelivery Delivery { get; }
        
        #endregion
    }
}