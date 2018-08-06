namespace Eda.Integrations.Delivery.Contracts
{
    /// <inheritdoc cref="IGeography" />
    /// <summary>
    /// The address data contract
    /// </summary>
    public interface IAddress : IGeography, IObject
    {
        #region Properties
        
        /// <summary>
        /// Gets the country.
        /// </summary>
        ICountry Country { get; }
        
        
        /// <summary>
        /// Gets the city.
        /// </summary>
        ICity City { get; }

        
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
        
        #endregion
    }
}