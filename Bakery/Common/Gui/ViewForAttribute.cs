using System;

namespace Fortius.Gui
{
    /// <summary>
    /// Обеспечивает привязку представления к типу модели
    /// </summary>
    public class ViewForAttribute : Attribute
    {
        /// <summary>
        /// Обеспечивает привязку представления к типу модели
        /// </summary>
        /// <param name="model">Тип модели</param>
        public ViewForAttribute(Type model)
        {
            
        }
    }
}