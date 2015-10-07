using System;
using System.Collections.Generic;

namespace Mcs.Model
{
    /// <summary>
    /// Устройство
    /// </summary>
    public class Device : Entity
    {
        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Последний вход в систему
        /// </summary>
        public DateTime LastCheckin { get; set; }

        /// <summary>
        /// Заказы с устройства
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
    }
}