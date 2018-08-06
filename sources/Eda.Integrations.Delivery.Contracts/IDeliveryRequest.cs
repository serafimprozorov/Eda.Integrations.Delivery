namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The data contract for the delivery request.
    /// </summary>
    public interface IDeliveryRequest
    {
        /// <summary>
        /// Gets the source address.
        /// </summary>
        IAddress SourceAddress { get; }
        
        
        /// <summary>
        /// Gets the destination address.
        /// </summary>
        IAddress DestinationAddress { get; }
        
        
        /// <summary>
        /// Gets the delivery type.
        /// </summary>
        string DeliveryType { get; }
        
        
        /// <summary>
        /// Gets the parcel information.
        /// </summary>
        IParcel Parcel { get; }
        
        
        /// <summary>
        /// Gets the currency.
        /// </summary>
        object Currency { get; }
    }
}