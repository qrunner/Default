namespace Mcs.Model
{
    /// <summary>
    /// Блюдо
    /// </summary>
    public class Dish : NamedEntity
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int MenuCategoryId { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Список тегов
        /// </summary>
        public Tag[] Tags { get; set; }
    }
}