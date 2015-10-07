using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Services
{
    public interface IPlaceServiceBase<T> : IServiceBase<T> where T : IEntity
    {
        /// <summary>
        /// Получает коллекцию сущностей, относящихся к заведению
        /// </summary>
        /// <param name="placeId">Идентификатор заведения</param>
        /// <returns>Коллекцию сущностей T</returns>
        IEnumerable<T> GetOfPlace(int placeId);

        /// <summary>
        /// Получает коллекцию сущностей, относящихся к заведению
        /// </summary>
        /// <param name="placeId">Идентификатор заведения</param>
        /// <param name="skip">Пропустить элементов</param>
        /// <param name="take">Выбрать элементов</param>
        /// <returns>Коллекцию сущностей T</returns>
        IEnumerable<Order> GetOfPlace(int placeId, int skip, int take);
    }
}