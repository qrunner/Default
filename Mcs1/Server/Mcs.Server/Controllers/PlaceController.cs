using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mcs.Server.Controllers
{
    public class PlaceController : ApiController
    {
        
        // GET api/place
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }

        // GET api/place/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
