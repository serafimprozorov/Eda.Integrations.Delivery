namespace Eda.Integrations.Delivery
{
    /// <inheritdoc />
    /// <summary>
    /// The data contract for pick point.
    /// </summary>
    public interface IPickPoint : IObject
    {
        /// <summary>
        /// Gets the working schedule.
        /// </summary>
        WorkingWeekSchedule WorkingSchedule { get; }
        
        
        /// <summary>
        /// Gets the address. 
        /// </summary>
        IAddress Address { get; }       
    }
}