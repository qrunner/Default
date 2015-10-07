using Bakery.Model;
using Fortius.Gui;

namespace Bakery.UI
{
    public static class ModelRoutes
    {
        public const string RefCompanies = "RefCompanies";

        public static void Register()
        {
            ModelController.RegisterRoute(RefCompanies, Route.Create<Reference<Company>>(true));
        }
    }
}