using Membership;

namespace Accounting
{
    /// <summary>
    /// Информация о проводке - сторно
    /// </summary>
    public class RollbackOperationInfo : OperationInfo
    {
        public RollbackOperationInfo(long id, IUser performer, OperationInfo baseOperation)
            : base(id, baseOperation.Category, performer)
        {
            RollbackOfId = baseOperation.Id;
        }

        /// <summary>
        /// Идентификатор сторнируемой проводки
        /// </summary>
        public long RollbackOfId { get; private set; }
    }
}