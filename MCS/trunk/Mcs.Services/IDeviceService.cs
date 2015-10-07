using Mcs.Model;

namespace Mcs.Services
{
    public interface IDeviceService : IServiceBase<Device>
    {
        /// <summary>
        /// Возвращает идентификатор устройства в хранилище по внутреннему идентификатору устройства
        /// </summary>
        /// <param name="deviceNumber">Внутрений идентификатор устройства (Vendor-specified)</param>
        /// <returns>Идентификатор в хранилище</returns>
        int GetDeviceId(string deviceNumber);

        /// <summary>
        /// Обновляет время последней активности для устройства
        /// </summary>
        /// <param name="id"></param>
        void UpdateLastActivity(int id);
    }
}