namespace Crossover.AMS.Contracts.TaskPlanning
{
    /// <summary>
    /// Schedule type
    /// </summary>
    public enum ScheduleType
    {
        /// <summary>
        /// Just need to start at Start datetime
        /// </summary>
        Plain,
        /// <summary>
        /// Should be processed from Start to End datettime
        /// </summary>
        Continious,

        /// <summary>
        /// Should be started from Start and repeated with Period until End
        /// </summary>
        Reccurent
    }
}