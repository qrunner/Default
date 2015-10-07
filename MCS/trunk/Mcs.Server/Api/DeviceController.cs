using System.Web.Http;
using Mcs.Model;
using Mcs.Services;

namespace Mcs.Server.Api
{
    public class DeviceController : BaseApiController<Device, IDeviceService, Model.Json.Device>
    {
        [HttpGet]
        public int DeviceId(string deviceNumber)
        {
            return ServiceInterface.GetDeviceId(deviceNumber);
        }
    }
}