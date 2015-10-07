namespace Sirius.ServiceLayer
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        int Id { get; set; }
    }
}
