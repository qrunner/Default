using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Mcs.WebExtensions
{
    public static class Forms
    {
        public static MvcHtmlString TextBoxBlockFor<TModel, TValue>(this HtmlHelper<TModel> html, string label, Expression<Func<TModel, TValue>> expression)
        {
            var sb = new StringBuilder();

            sb.AppendLine(@"<div class=""f-row"">");
            sb.AppendFormat("<label>{0}</label>", label.EndsWith(":") ? label : label + ":");
            sb.AppendLine(@"<div class=""f-input"">");
            sb.AppendLine(html.TextBoxFor(expression, new { @class = "g-5" }).ToString());
            sb.AppendLine(@"<span class=""f-input-comment"">");
            sb.AppendLine(html.ValidationMessageFor(expression).ToString());
            sb.AppendLine(@"</span>");
            sb.AppendLine(@"</div>");
            sb.AppendLine(@"</div>");

            return new MvcHtmlString(sb.ToString());
        }

        public static MvcHtmlString DropDownListBlockFor<TModel, TProperty>(this HtmlHelper<TModel> html, string label, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList)
        {
            var sb = new StringBuilder();

            sb.AppendLine(@"<div class=""f-row"">");
            sb.AppendFormat("<label>{0}</label>", label.EndsWith(":") ? label : label + ":");
            sb.AppendLine(@"<div class=""f-input"">");
            sb.AppendLine(html.DropDownListFor(expression, selectList, new { @class = "g-5" }).ToString());
            sb.AppendLine(@"<span class=""f-input-comment"">");
            sb.AppendLine(html.ValidationMessageFor(expression).ToString());
            sb.AppendLine(@"</span>");
            sb.AppendLine(@"</div>");            
            sb.AppendLine(@"</div>");

            return new MvcHtmlString(sb.ToString());
        }

        public static MvcHtmlString EditBlockFor<TModel, TProperty>(this HtmlHelper<TModel> html, string label, Expression<Func<TModel, TProperty>> expression, MvcHtmlString innerControl)
        {
            var sb = new StringBuilder();

            sb.AppendLine(@"<div class=""f-row"">");
            sb.AppendFormat("<label>{0}</label>", label.EndsWith(":") ? label : label + ":");
            sb.AppendLine(@"<div class=""f-input"">");
            sb.AppendLine(innerControl.ToString());
            sb.AppendLine(@"<span class=""f-input-comment"">");
            sb.AppendLine(html.ValidationMessageFor(expression).ToString());
            sb.AppendLine(@"</span>");
            sb.AppendLine(@"</div>");
            sb.AppendLine(@"</div>");

            return new MvcHtmlString(sb.ToString());
        }

        public static MvcHtmlString CancelButton(this HtmlHelper html)
        {
            return new MvcHtmlString(string.Format(@"<a href=""{0}"" class=""f-bu"">Отмена</a>", HttpContext.Current.Request.QueryString["returl"]));
        }

        public static MvcHtmlString CreateButton(this HtmlHelper html, string controller)
        {
            return html.ActionLink("Добавить", "create", controller, new {returl=HttpContext.Current.Request.RawUrl}, new{ @class="f-bu"});
        }

        public static MvcHtmlString SaveButton(this HtmlHelper html)
        {
            return new MvcHtmlString(@"<input type=""submit"" class=""f-bu f-bu-default"" value=""Сохранить""/>");
        }

        public static MvcHtmlString SubmitButton(this HtmlHelper html, string label)
        {
            return new MvcHtmlString(@"<input type=""submit"" class=""f-bu f-bu-default"" value=""" + label + @"""/>");
        }
        
    }
}