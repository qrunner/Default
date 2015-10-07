namespace Accounting
{
    /// <summary>
    /// Транзакция
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Подтверждает выполнение транзакции
        /// </summary>
        void Commit();

        /// <summary>
        /// Откатывает транзакцию
        /// </summary>
        void Rollback();
    }
}