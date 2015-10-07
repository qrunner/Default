using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Services
{
    /// <summary>
    /// Служба, работы с объектами, относящимися к заведению
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    public interface IPlaceRelatedService<T> : IServiceBase<T> where T : IPlaceRelatedEntity
    {
        /// <summary>
        /// Получает все элементы для заданного заведения
        /// </summary>
        /// <param name="placeId">Идентификатор заведения</param>
        /// <returns>Коллекция объектов</returns>
        IEnumerable<T> GetOfPlace(int placeId);
    }
}