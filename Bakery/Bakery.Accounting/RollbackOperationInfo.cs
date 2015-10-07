using Membership;

namespace Accounting
{
    /// <summary>
    /// ���������� � �������� - ������
    /// </summary>
    public class RollbackOperationInfo : OperationInfo
    {
        public RollbackOperationInfo(long id, IUser performer, OperationInfo baseOperation)
            : base(id, baseOperation.Category, performer)
        {
            RollbackOfId = baseOperation.Id;
        }

        /// <summary>
        /// ������������� ������������ ��������
        /// </summary>
        public long RollbackOfId { get; private set; }
    }
}