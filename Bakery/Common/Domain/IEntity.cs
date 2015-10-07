namespace Fortius.Domain
{
    /// <summary>
    /// Представляет идентифицируемую сущность
    /// </summary>
    /// <typeparam name="T">Тип идентификатора</typeparam>
    public interface IEntity<out T> where T : struct
    {
        /// <summary>
        /// Идентификтор сущности
        /// </summary>
        T Id { get; }
    }
}