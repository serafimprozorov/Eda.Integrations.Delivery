namespace Eda.Integrations.Delivery.Contracts
{
    /// <summary>
    /// The data contract for contact.
    /// </summary>
    public interface IContact
    {
        #region Properties
        
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }
        
        
        /// <summary>
        /// Gets the phone.
        /// </summary>
        string Phone { get; }
        
        #endregion
    }
}