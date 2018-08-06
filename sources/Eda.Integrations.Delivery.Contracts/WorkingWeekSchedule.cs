using System;
using System.Collections.Generic;
using System.Linq;


namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The working schedule.
    /// </summary>
    public readonly struct WorkingWeekSchedule
    {
        private readonly WorkingHours?[] _workingWeekSchedule;


        #region Constructor
        
        /// <summary>
        /// Initialize a new instance of the <see cref="WorkingWeekSchedule"/> type.
        /// If the pick point doesn't work in specified day of week
        /// the null must be passed as <see cref="WorkingHours"/>.
        /// </summary>
        /// <param name="workingWeekSchedule">The schedule.</param>
        public WorkingWeekSchedule(WorkingHours?[] workingWeekSchedule) => _workingWeekSchedule = workingWeekSchedule;

        #endregion
        
        #region Properties

        /// <summary>
        /// Gets the <see cref="WorkingHours"/> for specified <paramref name="dayOfWeek"/>.
        /// </summary>
        /// <param name="dayOfWeek">The day of week.</param>
        public WorkingHours? this[DayOfWeek dayOfWeek] => _workingWeekSchedule[(int) dayOfWeek];
        
        #endregion
    }
}