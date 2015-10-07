using System.Collections.Generic;
using Crossover.AMS.Models;

namespace Crossover.AMS.Communication.Models
{
    /// <summary>
    /// Communication room
    /// </summary>
    public class Room : Entity
    {
        /// <summary>
        /// Communication room name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Accident 
        /// </summary>
        public virtual Accident Accident { get; set; }

        /// <summary>
        /// Room is permanent
        /// </summary>
        public bool Permanent { get; set; }

        /// <summary>
        /// Messages of the room
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }

        /// <summary>
        /// Users in the room
        /// </summary>
        public virtual ICollection<UserInfo> Users { get; set; }

        /// <summary>
        /// Type of room
        /// </summary>
        public RoomType Type { get; set; }

        public string User1 { get; set; }

        public string User2 { get; set; }
    }
}