namespace Eda.Integrations.Delivery.Contracts
{
    /// <summary>
    /// The data contract for the delivery request.
    /// </summary>
    public interface IDeliveryRequest
    {
        #region Properties
        
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
        object DeliveryType { get; }
        
        /// <summary>
        /// Gets the parcel information.
        /// </summary>
        IParcel Parcel { get; }
        
        #endregion
    }
}