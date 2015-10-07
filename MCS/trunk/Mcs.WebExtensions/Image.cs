using System.Web.Mvc;
using Mcs.Model;
using Mcs.Services;

namespace Mcs.WebExtensions
{
    public static class Image
    {
        /// <summary>
        /// Возвращает URI изображения в оригинальном размере
        /// </summary>        
        /// <returns>URI изображения</returns>
        public static string GetImagePath(this IEntity item)
        {
            IPictureService ps = Config.ServiceFactory.GetService<IPictureService>();
            return ps.GetImagePath(item.GetEntityTypeName(), item.Id);
        }
        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер с обрезкой
        /// </summary>        
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <returns>URI изображения</returns>
        public static string GetImagePath(this IEntity item, int width, int height)
        {
            IPictureService ps = Config.ServiceFactory.GetService<IPictureService>();
            return ps.GetImagePath(item.GetEntityTypeName(), item.Id, width, height);
        }

        private static string GetEntityTypeName(this IEntity item)
        {
            return item.GetType().Name.Length > 15 ? item.GetType().BaseType.Name : item.GetType().Name;
        }

        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер по длинной стороне
        /// </summary>
        /// <param name="size">Размер по длинной стороне</param>
        /// <returns>URI изображения</returns>
        public static string GetImagePathFit(this IEntity item, int size)
        {
            var ps = Config.ServiceFactory.GetService<IPictureService>();
            return ps.GetImagePathFit(item.GetEntityTypeName(), item.Id, size);
        }
        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер по высоте
        /// </summary>
        /// <param name="height">Высота</param>
        /// <returns>URI изображения</returns>
        /*public static string GetImagePathFitHeight(this IEntity item, int height)
        {
            IPictureService ps = Config.ServiceFactory.GetService<IPictureService>();
            return ps.GetImagePathFitHeight(item.GetType().Name, item.Id, height);
        }*/
        /// <summary>
        /// Возвращает URI изображения, вписанное в заданный размер по ширине
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <returns>URI изображения</returns>
        public static string GetImagePathFitWidth(this IEntity item, int width)
        {
            IPictureService ps = Config.ServiceFactory.GetService<IPictureService>();
            return ps.GetImagePathFitWidth(item.GetEntityTypeName(), item.Id, width);
        }
        /// <summary>
        /// Сохраняет изображение
        /// </summary>
        /// <param name="picture">Изображение</param>
        public static void SetPicture(this IEntity item, System.Drawing.Image picture)
        {
            var ps = Config.ServiceFactory.GetService<IPictureService>();
            ps.SetPicture(item.GetEntityTypeName(), item.Id, picture);
        }

        public static MvcHtmlString PlaceImage(this HtmlHelper htmlHelper, int heigth, Entity item)
        {
            return new MvcHtmlString(string.Format("<img src='/content/images/base/{0}/{1}.png?h={2}' />", item.GetEntityTypeName(), item.Id, heigth));
        }
    }
}