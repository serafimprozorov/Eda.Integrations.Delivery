namespace Eda.Integrations.Delivery.Contracts
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for pick point.
    /// </summary>
    public interface IPickupPoint : IObject
    {
        /// <summary>
        /// Gets the working hours.
        /// </summary>
        IWorkingHours WorkingHours { get; }
        
        
        /// <summary>
        /// Gets the address. 
        /// </summary>
        IAddress Address { get; }       
    }
}