using System;

namespace Crossover.AMS.Contracts.Messaging
{
    /// <summary>
    /// Enterprise service bus message. 
    /// Wraps data, sended throw ESB.
    /// </summary>
    public interface IMessage<out T>
    {
        /// <summary>
        /// Message corellation identifier
        /// </summary>
        Guid CorellationId { get; set; }

        /// <summary>
        /// Message data
        /// </summary>
        T Data { get; }

        /// <summary>
        /// Confirms message processed
        /// </summary>
        void Confirm();
    }
}