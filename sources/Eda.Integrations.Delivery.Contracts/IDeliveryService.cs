using System.Threading;
using System.Threading.Tasks;

using Eda.Integrations.Delivery.DependencyInjection;


namespace Eda.Integrations.Delivery.Contracts
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
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="ct">The cancellation token.</param>
        /// <returns>
        /// An instance of the <see cref="IDelivery"/> type.
        /// </returns>
        Task<IDelivery> CreateDelivery(IDeliveryRequest request, CancellationToken ct = default);

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="delivery"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDeliveryOrder> GetDeliveryOrder(IDelivery delivery, CancellationToken ct = default);

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<string> GetDeliveryTrackingNumber(IDeliveryOrder order, CancellationToken ct = default);
        
        #endregion
    }
}