using System;

namespace Crossover.AMS.Contracts.Messaging
{
    /// <summary>
    /// ESB Message consumer
    /// </summary>
    public interface IMessageConsumer<out T>
    {
        /// <summary>
        /// Endpoint (queue or topic) name
        /// </summary>
        string Endpoint { get; }

        /// <summary>
        /// Reads message from defined endpoint
        /// </summary>
        /// <param name="timeout">Reading timeout</param>
        /// <returns>First message in queue</returns>
        IMessage<T> ReadMessage(int timeout);

        /// <summary>
        /// Reads message from defined endpoint with given Corellation Id
        /// </summary>
        /// <param name="corellationId">Message Corellation Id</param>
        /// <param name="timeout">Reading timeout</param>
        /// <returns>First message in queue with given Corellation Id</returns>
        IMessage<T> ReadMessage(Guid corellationId, int timeout);
    }
}