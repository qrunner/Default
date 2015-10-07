using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mcs.Services;

namespace Mcs.Client.App_Start
{
    public static class Config
    {
        static IServiceFactory _serviceFactory;
              

        public static IServiceFactory ServiceFactory
        {
            get
            {
                return _serviceFactory;
            }
        }
    }
}