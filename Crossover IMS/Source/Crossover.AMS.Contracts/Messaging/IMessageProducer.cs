using System;

namespace Crossover.AMS.Contracts.Messaging
{
    /// <summary>
    /// ESB Message producer
    /// </summary>
    public interface IMessageProducer<in T>
    {
        /// <summary>
        /// Endpoint (queue or topic) name
        /// </summary>
        string Endpoint { get; }
        /// <summary>
        /// Sends message to defined endpoint
        /// </summary>
        /// <param name="data">Message data</param>
        /// <returns>Message corellation id</returns>
        Guid SendMessage(T data);
    }
}