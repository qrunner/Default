using System;

namespace Crossover.AMS.Contracts.TaskPlanning
{
    public interface ITask
    {
        long Id { get; }

        ISchedule Schedule { get; }

        DateTime Started { get; set; }

        DateTime Finished { get; set; }

        TaskState State { get; set; }

        string Title { get; set; }

        string Description { get; set; }

        string[] Attachments { get; set; }

        long AccidentId { get; }

        string Category { get; set; }

        Guid AssigneeSid { get; set; }
    }
}