namespace Eda.Integrations.Delivery
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for delivery order.
    /// </summary>
    public interface IDeliveryOrder : IObject
    {
        /// <summary>
        /// Gets the delivery.
        /// </summary>
        IDelivery Delivery { get; }
    }
}