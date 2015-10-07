using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Services.MySql
{
    public class PlaceRelatedService<T> : ServiceBase<T>, IPlaceRelatedService<T>
        where T : class, IPlaceRelatedEntity
    {
        public IEnumerable<T> GetOfPlace(int placeId)
        {
            return Get(x => x.PlaceId == placeId);            
        }

        public IEnumerable<T> GetOfPlace(int placeId, int skip, int take)
        {
            return Get(x => x.PlaceId == placeId, skip, take);
        }
    }
}