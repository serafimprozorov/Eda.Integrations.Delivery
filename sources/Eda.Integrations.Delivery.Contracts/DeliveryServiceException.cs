using System;


namespace Eda.Integrations.Delivery.Contracts
{
    /// <inheritdoc />
    /// <summary>
    /// The delivery service error. 
    /// </summary>
    public abstract class DeliveryServiceException : Exception
    {
        #region Constructor
        
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the
        /// <see cref="T:Eda.Integrations.Delivery.Contracts.DeliveryServiceException" /> type.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        protected DeliveryServiceException(string message, Exception innerException) : base(message, innerException) { }
        
        #endregion
    }
}