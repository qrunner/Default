namespace Invoice.Model
{
    /// <summary>
    /// Фабрика служб
    /// </summary>
    public interface IServiceFactory
    {
        /// <summary>
        /// Возвращает службу для указанного тпа сущности
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <returns>Экземпляр службы для работы с сущностями</returns>
        IService<T> GetService<T>() where T:Entity;
    }
}