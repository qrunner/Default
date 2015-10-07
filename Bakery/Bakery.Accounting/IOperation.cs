namespace Accounting
{
    /// <summary>
    /// Операция / проводка
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Выполняет операцию
        /// </summary>
        /// <returns>Информация об операции</returns>
        OperationInfo Execute();

        /// <summary>
        /// Сторнирует операцию
        /// </summary>
        /// <param name="operation">Информация о сторнируемой операции</param>
        /// <returns>Информация о сторнирующей операции</returns>
        OperationInfo Reverse(OperationInfo operation);
    }
}