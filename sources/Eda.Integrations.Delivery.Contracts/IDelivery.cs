namespace Eda.Integrations.Delivery
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for the delivery.
    /// </summary>
    public interface IDelivery : IObject
    {
        /// <summary>
        /// Gets the cost.
        /// </summary>
        decimal Cost { get; }
        
        
        /// <summary>
        /// Gets the currency.
        /// </summary>
        object Currency { get; }
        
        
        /// <summary>
        /// Gets the delivery type.
        /// </summary>
        string Type { get; }
        
        
        /// <summary>
        /// Gets the source address.
        /// </summary>
        IAddress SourceAddress { get; }
        
        
        /// <summary>
        /// Gets the destination address.
        /// </summary>
        IAddress DestinationAddress { get; }
        
        
        /// <summary>
        /// Gets the pick point.
        /// </summary>
        IPickPoint PickPoint { get; }
        
        
        /// <summary>
        /// Gets the parcel.
        /// </summary>
        IParcel Parcel { get; }
    }
}