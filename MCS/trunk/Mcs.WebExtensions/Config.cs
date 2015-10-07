using Mcs.Services;

namespace Mcs.WebExtensions
{
    public static class Config
    {
        static Config()
        {
            ServiceFactory = new ServiceFactory();
        }

        public static IServiceFactory ServiceFactory { get; private set; }
    }
}
