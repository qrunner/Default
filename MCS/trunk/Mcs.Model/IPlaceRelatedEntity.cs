namespace Mcs.Model
{
    /// <summary>
    /// Сущность, относящаяся к заведению
    /// </summary>
    public interface IPlaceRelatedEntity : IEntity
    {
        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        int PlaceId { get; set; }
    }
}
