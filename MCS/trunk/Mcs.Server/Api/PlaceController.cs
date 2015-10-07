using System.Collections.Generic;
using System.Linq;
using Mcs.Model;
using Mcs.Server.JsonMappers;
using Mcs.Services;

namespace Mcs.Server.Api
{
    public class PlaceController : BaseApiController<Place, IPlaceService, Model.Json.Place>
    {
        // GET api/place
        public IEnumerable<Model.Json.Place> Get()
        {
            return ServiceInterface.Get().Select(Mapper.Map<Place, Model.Json.Place>);
        }
    }
}