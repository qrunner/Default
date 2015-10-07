namespace Fortius.Gui
{
    /// <summary>
    /// Представление
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Устанавливает источник данных для представления
        /// </summary>
        /// <param name="model"></param>
        void Bind(object model);

        object Model { get; }
    }
}