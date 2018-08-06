namespace Eda.Integrations.Delivery.SpsrExpress
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for the SPSR Express contact.
    /// </summary>
    public class SpsrExpressContact : IContact
    {
        #region Constructor
        
        internal SpsrExpressContact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
        
        #endregion
        
        #region IContact

        /// <inheritdoc />
        public string Name { get; }
        
        /// <inheritdoc />
        public string Phone { get; }
        
        /// <inheritdoc />
        public string Email { get; }
        
        #endregion
    }
}