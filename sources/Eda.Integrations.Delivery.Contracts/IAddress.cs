namespace Eda.Integrations.Delivery
{
    /// <inheritdoc cref="IGeography" />
    /// <summary>
    /// The address data contract
    /// </summary>
    public interface IAddress : IGeography, IObject
    {
        /// <summary>
        /// Gets the postal code.
        /// </summary>
        string PostalCode { get; }
        
        /// <summary>
        /// Gets the street.
        /// </summary>
        IStreet Street { get; }

        
        /// <summary>
        /// Gets the building
        /// </summary>
        string Building { get; }
        
        
        /// <summary>
        /// Gets the contact.
        /// </summary>
        IContact Contact { get; }
        
        
        /// <summary>
        /// Gets the note.
        /// </summary>
        string Note { get; }
    }
}