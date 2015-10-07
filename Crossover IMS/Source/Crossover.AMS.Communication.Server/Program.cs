using System;
using System.ServiceModel;

namespace Crossover.AMS.Communication.Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(PublicCommunicationService)))
            {
                host.Description.Behaviors.Insert(0, new GlobalExceptionHandlerBehavior());
                host.Open();

                Console.WriteLine("The service is ready");
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}