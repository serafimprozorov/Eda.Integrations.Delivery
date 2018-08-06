namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The data contract for contact.
    /// </summary>
    public interface IContact
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }
        
        
        /// <summary>
        /// Gets the phone.
        /// </summary>
        string Phone { get; }
        
        
        /// <summary>
        /// Gets the email.
        /// </summary>
        string Email { get; }
    }
}