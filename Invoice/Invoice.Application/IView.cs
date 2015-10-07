namespace Sirius.Desktop
{
    /// <summary>
    /// Представление
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Устанавливает модель для представления
        /// </summary>
        void SetModel(IViewModel model);
    }
}