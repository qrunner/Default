using System;
using System.Collections.Generic;
using Crossover.AMS.Models;

namespace Crossover.AMS.Communication.Models
{
    public class Accident : Entity
    {
        /// <summary>
        /// Accident communication rooms
        /// </summary>
        public virtual ICollection<Room> Rooms { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual AccidentCategory Category { get; set; }

        public DateTime Registered { get; set; }

        public DateTime Resolved { get; set; }

        public AccidentState State { get; set; }
    }
}