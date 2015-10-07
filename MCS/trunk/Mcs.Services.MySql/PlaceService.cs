using System.Collections.Generic;
using System.Linq;
using Mcs.Model;

namespace Mcs.Services.MySql
{
    public class PlaceService : ServiceBase<Place>, IPlaceService
    {
        public IEnumerable<Place> Get()
        {
            using (var ctx = new Context())
            {
                return Table(ctx).ToArray();
            }
        }
    }
}