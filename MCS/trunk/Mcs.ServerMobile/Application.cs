using System.Collections.Generic;
using System.Web;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.ServerMobile
{
    public class Application
    {
        static readonly IPlaceService PlaceService = Config.ServiceFactory.GetService<IPlaceService>();

        public static int CurrentPlaceId
        {
            get { return HttpContext.Current.Session["placeId"] != null ? (int)HttpContext.Current.Session["placeId"] : 0; }
            set { HttpContext.Current.Session["placeId"] = value; }
        }

        public static int CurrentCategoryId
        {
            get { return HttpContext.Current.Session["categoryId"] != null ? (int)HttpContext.Current.Session["categoryId"] : 0; }
            set { HttpContext.Current.Session["categoryId"] = value; }
        }

        public static IEnumerable<Place> AvailablePlaces { get { return PlaceService.Get(); } }

        public static string CurrentPlaceName
        {
            get
            {
                var id = CurrentPlaceId;
                return id > 0 ? PlaceService.Get(id).Name : "[выберите заведение]";
            }
        }
    }
}