namespace Mcs.Model
{
    /// <summary>
    /// Результат операции
    /// </summary>
    public class OperationResult
    {
        /// <summary>
        /// Результат операции
        /// </summary>
        public ResultType Result { get; set; }
        /// <summary>
        /// Информационный код
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Информационное сообщение
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// Тип результата операции
    /// </summary>
    public enum ResultType
    {
        /// <summary>
        /// Успешно
        /// </summary>
        Success = 0,
        /// <summary>
        /// Ошибка
        /// </summary>
        Error = 1,
        /// <summary>
        /// Отказано в доступе
        /// </summary>
        AccessDenied = 2
    }
}