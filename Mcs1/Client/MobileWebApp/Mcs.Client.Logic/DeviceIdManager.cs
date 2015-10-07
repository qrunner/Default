using System;
using System.Web;

namespace Mcs.Client.Logic
{
    public class DeviceIdManager
    {
        /// <summary>
        /// Название ключа параметра в сессии ASP.NET, который хранит идентификтор устройства
        /// </summary>
        public const string CartSessionKey = "DeviceId";

        /// <summary>
        /// Возвращает идентификатор устройства
        /// </summary>
        /// <param name="context">Контекст HTTP-запроса</param>
        /// <returns></returns>
        public static string GetDeviceId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                context.Session[CartSessionKey] = Guid.NewGuid();
            }
            return context.Session[CartSessionKey].ToString();
        }
    }
}
