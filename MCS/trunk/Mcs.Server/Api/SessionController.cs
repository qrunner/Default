using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mcs.Server.Api
{
    public class SessionController : ApiController
    {
        /// <summary>
        /// Get session ID by device ID
        /// </summary>
        /// <param name="id">Device ID</param>
        /// <returns>Session ID</returns>
        public string Get(string id)
        {
            return string.Format("{0}:{1}", id, Guid.NewGuid());
        }
    }
}
