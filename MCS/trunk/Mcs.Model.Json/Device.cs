using System;

namespace Mcs.Model.Json
{
    /// <summary>
    /// Устройство
    /// </summary>
    public class Device : Entity
    {
        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        public string DeviceNumber { get; set; }

        /// <summary>
        /// Последний вход в систему
        /// </summary>
        public DateTime LastCheckin { get; set; }
    }
}