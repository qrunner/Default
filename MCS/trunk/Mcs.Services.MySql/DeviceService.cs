using System;
using System.Linq;
using Mcs.Model;

namespace Mcs.Services.MySql
{
    public class DeviceService : ServiceBase<Device>, IDeviceService
    {
        public int GetDeviceId(string deviceNumber)
        {
            var devices = Get(x => x.DeviceId == deviceNumber).ToArray();
            if (devices.Length > 0)
            {
                var device = devices[0];
                UpdateLastCheckin(device);
                return device.Id;
            }

            return Save(new Device {DeviceId = deviceNumber, LastCheckin = DateTime.Now}).Id;
        }

        public void UpdateLastActivity(int id)
        {
            var device = Get(x => x.Id == id).Single();
            UpdateLastCheckin(device);
        }

        private void UpdateLastCheckin(Device device)
        {
            device.LastCheckin = DateTime.Now;
            Save(device);
        }
    }
}