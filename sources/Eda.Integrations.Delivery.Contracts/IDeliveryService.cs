using System.Threading;
using System.Threading.Tasks;


namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The service contract for delivery service.
    /// </summary>
    public interface IDeliveryService
    {
        #region Properties
        
        /// <summary>
        /// Gets the factory.
        /// </summary>
        IDeliveryServiceFactory Factory { get; }
        
        
        /// <summary>
        /// Gets the geoservice.
        /// </summary>
        IDeliveryGeoService GeoService { get; }
        
        #endregion
        
        #region Methods
        
        /// <summary>
        /// Gets the delivery information for passed <paramref name="request"/>.
        /// Must throw an exception inherited from <see cref="DeliveryServiceException"/> in case of internal errors.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// An instance of the <see cref="IDeliveryInformation"/> type.
        /// </returns>
        Task<IDeliveryInformation> GetDeliveryInformation(IDeliveryRequest request, CancellationToken ct = default);

        
        /// <summary>
        /// Creates the delivery for passed <paramref name="request"/>.
        /// Must throw an exception inherited from <see cref="DeliveryServiceException"/> in case of internal errors.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// An instance of the <see cref="IDelivery"/> type.
        /// </returns>
        Task<IDelivery> CreateDelivery(IDeliveryRequest request, CancellationToken ct = default);

        
        /// <summary>
        /// Gets the delivery order.
        /// Must throw an exception inherited from <see cref="DeliveryServiceException"/> in case of internal errors.
        /// </summary>
        /// <param name="delivery">The delivery.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// The delivery order.
        /// </returns>
        Task<IDeliveryOrder> GetDeliveryOrder(IDelivery delivery, CancellationToken ct = default);

        
        /// <summary>
        /// Gets the tracking number.
        /// Must throw an exception inherited from <see cref="DeliveryServiceException"/> in case of internal errors.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// The delivery tracking number.
        /// </returns>
        Task<string> GetDeliveryTrackingNumber(IDeliveryOrder order, CancellationToken ct = default);
        
        #endregion
    }
}