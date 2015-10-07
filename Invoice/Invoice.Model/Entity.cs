namespace Invoice.Model
{
    /// <summary>
    /// Базовый класс сущности
    /// </summary>
    public class Entity : IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
    }
}
