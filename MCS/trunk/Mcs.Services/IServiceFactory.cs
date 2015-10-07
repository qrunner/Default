namespace Mcs.Services
{
    /// <summary>
    /// Фабрика служб
    /// </summary>
    public interface IServiceFactory
    {
        /// <summary>
        /// Получает экземпляр службы заданного типа
        /// </summary>
        /// <typeparam name="T">Тип службы</typeparam>
        /// <returns>Экземпляр службы</returns>
        T GetService<T>() where T : class;
    }
}