using System.Collections.Generic;

namespace Crossover.AMS.Communication.Chat.Entities
{
    public class RoomCollection : Dictionary<int, Room>
    {
        public Room Get(int key)
        {
            return this[key] ?? (this[key] = new Room());
        }

        /// <summary>
        /// Gets the chatroom by key, if is not created it creates a new one.
        /// </summary>
        public new Room this[int key]
        {
            get
            {
                if (!ContainsKey(key))
                {
                    base[key] = new Room();
                }
                return base[key];
            }
            set { base[key] = value; }
        }
    }
}