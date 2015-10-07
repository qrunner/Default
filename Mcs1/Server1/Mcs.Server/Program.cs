using System;
using System.ServiceModel;
using Mcs.Service;
using Mcs.Service.Storage.Database;
using System.Collections.Generic;

namespace Mcs.Server
{
    class Program
    {
        private static Type[] serviceTypes = new[] { typeof(PlaceService), typeof(DeskService), typeof(MenuCategoryService), typeof(DishService) };

        static void Main(string[] args)
        {
            Console.WriteLine("Starting Service...");

            var hosts = new List<ServiceHost>();
            try
            {
                foreach (var serviceType in serviceTypes)
                {
                    var host = new ServiceHost(serviceType);
                    hosts.Add(host);
                    host.Open();
                }

                Console.WriteLine("Service Started.");
                Console.WriteLine("Press 'q' to exit");

                while (true)
                    if (char.ToLower(Console.ReadKey().KeyChar) == 'q')
                        break;
            }
            finally
            {
                foreach (var host in hosts)
                    host.Close();
            }
        }
    }
}

/*class Program
    {
        static void Main(string[] args)
        {
            var svc = (ServicesSection)ConfigurationManager.GetSection("system.serviceModel/services");

            IList<ServiceHost> serviceHosts = new List<ServiceHost>();

            try
            {
                foreach (ServiceElement service in svc.Services)
                {
                    var host = new ServiceHost(Type.GetType(service.Name + ", Mcs.Service"));
                    serviceHosts.Add(host);
                    host.Open();
                }

                Console.WriteLine("Service Started");
                Console.WriteLine("Press any key to exit");

                while(true)                
                    if (char.ToLower(Console.ReadKey().KeyChar) == 'q') 
                        break;                
            }
            finally
            {
                foreach (var sh in serviceHosts)
                {
                    sh.Close();                    
                }
            }
        }
    }*/
