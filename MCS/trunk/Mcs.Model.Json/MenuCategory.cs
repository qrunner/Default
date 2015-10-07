namespace Mcs.Model.Json
{
    /// <summary>
    /// Категория меню
    /// </summary>    
    public class MenuCategory : NamedEntity
    {
        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }

        /// <summary>
        /// Идентификатор родительской категории
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Блюда категории
        /// </summary>
        //public Dish[] Dishes { get; set; }
    }
}