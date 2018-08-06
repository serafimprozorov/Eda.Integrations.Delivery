using System;


namespace Eda.Integrations.Delivery
{
    /// <summary>
    /// The working hours
    /// </summary>
    public readonly struct WorkingHours
    {
        public readonly TimeSpan Start;
        public readonly TimeSpan End;
        
        
        #region Constructor
        
        public WorkingHours(TimeSpan start, TimeSpan end)
        {
            Start = start;
            End = end;
        }
        
        #endregion
    }
}