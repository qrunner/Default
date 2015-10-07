using System;

namespace Crossover.AMS.Contracts.TaskPlanning
{
    public interface ISchedule
    {
        ScheduleType Type { get; set; }

        DateTime Start { get; set; }

        DateTime End { get; set; }

        TimeSpan Period { get; set; }
    }
}