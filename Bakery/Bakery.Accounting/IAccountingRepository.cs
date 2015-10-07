using Fortius.Domain;

namespace Accounting
{
    public interface IAccountingRepository : IRepository
    {
        /// <summary>
        /// Создает новую проводку
        /// </summary>
        /// <param name="category">Категория проводки</param>
        /// <returns>Экземпляр</returns>
        OperationInfo NewOperation(string category);

        /// <summary>
        /// Создает сторно-проводку
        /// </summary>
        /// <param name="baseOperation"></param>
        /// <returns></returns>
        OperationInfo NewReverseOperation(OperationInfo baseOperation);
    }
}