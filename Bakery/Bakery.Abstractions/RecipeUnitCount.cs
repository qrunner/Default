namespace Bakery.Model
{
    /// <summary>
    /// Количество единиц в рецепте
    /// </summary>
    public class RecipeUnitCount : UnitCount
    {
        /// <summary>
        /// Идентификатор рецепта
        /// </summary>
        public int RecipeId { get; set; }
    }
}
