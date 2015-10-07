using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Mcs.Model;
using Mcs.Services;

namespace Mcs.Server.Api
{
    public class PlaceRelatedController<TPlaceRelatedEntity, TJsonEntity> : BaseApiController<TPlaceRelatedEntity, IPlaceRelatedService<TPlaceRelatedEntity>, TJsonEntity>
        where TPlaceRelatedEntity : class, IPlaceRelatedEntity, IEntity, new()
        where TJsonEntity : class, new()
    {
        private IPlaceRelatedService<TPlaceRelatedEntity> PlaceRelatedService
        {
            get { return (IPlaceRelatedService<TPlaceRelatedEntity>) Service; }
        }

        [HttpGet]
        public virtual IEnumerable<TJsonEntity> Place(int placeId)
        {
            return PlaceRelatedService.GetOfPlace(placeId).Select(Mapper.Map<TPlaceRelatedEntity, TJsonEntity>);
        }
    }
}
