using System;
using Membership;

namespace Accounting
{
    /// <summary>
    /// Информация об операции / проводке
    /// </summary>
    public class OperationInfo
    {
        public OperationInfo(long id, string category, IUser performer)
        {
            Id = id;
            Category = category;
            Date = DateTime.Now;
            State = OperationState.Draft;
            Performer = performer;
        }

        /// <summary>
        /// Идентификатор проводки
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Дата и время выполнения
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Наименование проводки
        /// </summary>
        public string Category { get; private set; }

        /// <summary>
        /// Статус проводки
        /// </summary>
        public OperationState State { get; set; }

        /// <summary>
        /// Выполнивший пользователь
        /// </summary>
        public IUser Performer { get; private set; }

        /// <summary>
        /// Идентификатор сторно-проводки
        /// </summary>
        public long? RollbackedById { get; private set; }
    }
}