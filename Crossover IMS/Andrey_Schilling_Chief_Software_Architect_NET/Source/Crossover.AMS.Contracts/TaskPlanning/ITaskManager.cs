using System;
using System.Collections.Generic;

namespace Crossover.AMS.Contracts.TaskPlanning
{
    public interface ITaskManager
    {
        ITask CreateTask(long accidentId, ITask taskData);

        ITask GetTask(long taskId);

        IEnumerable<ITask> GetTasks(Guid assigneeSid);

        void ChangeTask(ITask task);

        void DeleteTask(long taskId);
    }
}