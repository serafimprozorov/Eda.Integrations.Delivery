using System;


namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The working hours
    /// </summary>
    public readonly struct WorkingHours
    {
        /// <summary>
        /// Gets the start time.
        /// </summary>
        public readonly TimeSpan Start;
        
        /// <summary>
        /// Gets the end time
        /// </summary>
        public readonly TimeSpan End;
        
        
        #region Constructor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkingHours"/> type.
        /// </summary>
        /// <param name="start">Start time.</param>
        /// <param name="end">End time.</param>
        public WorkingHours(TimeSpan start, TimeSpan end)
        {
            Start = start;
            End = end;
        }
        
        #endregion
    }
}