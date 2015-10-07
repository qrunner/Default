using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace Mcs.Server.Extensions
{
    public static class Links
    {
        public static MvcHtmlString EditLinks(this HtmlHelper htmlHelper, string controller, int id)
        {
            return new MvcHtmlString(
                @"<span class=""f-buttons"">"
                +
                htmlHelper.ActionLink("..", "edit", controller, new { id = id, returl = HttpContext.Current.Request.Url.PathAndQuery }, new { @class = "f-bu" }).ToString() +
                htmlHelper.ActionLink("X", "delete", controller, new { id = id, returl = HttpContext.Current.Request.Url.PathAndQuery }, new { @class = "f-bu" }).ToString()
                +
                @"</span>");

        }

        public static MvcHtmlString Navigation(this HtmlHelper htmlHelper)
        {
            RouteData route = htmlHelper.ViewContext.RequestContext.RouteData;
            string controller = route.GetRequiredString("controller");

            string retval = @"<ul class=""f-nav f-nav-tabs"">";
            var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            var navItems = new[]
            {                
                new{Name=string.Format("<img src='{0}' width='16px' height='16px'/>", urlHelper.Content("~/content/images/home.png")) , Controller="home"},
                new{Name="Заказы", Controller="order"},
                new{Name="Меню", Controller="menu"},
                new{Name="Столы", Controller="desk"},
                new{Name="Новости", Controller="news"},
                new{Name="Акции", Controller="promo"}
            };
            foreach (var item in navItems)
            {
                retval += string.Format(@"<li {2}><a href=""/{1}"">{0}</a></li>", item.Name, item.Controller,
                    string.Equals(controller, item.Controller, StringComparison.InvariantCultureIgnoreCase) ? @"class=""active""" : null);
            }
            retval += @"</ul>";
            return new MvcHtmlString(retval);
        }
    }
}