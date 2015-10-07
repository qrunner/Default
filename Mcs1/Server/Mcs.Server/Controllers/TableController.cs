using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mcs.Server.Controllers
{
    public class TableController : ApiController
    {
        // GET api/table
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }

        // GET api/table/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/table
        public void Post([FromBody]string value)
        {
        }

        // PUT api/table/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/table/5
        public void Delete(int id)
        {
        }
    }
}
