namespace Crossover.AMS.Contracts.Messaging
{
    /// <summary>
    /// Enterprise Messaging Service
    /// </summary>
    public interface IMessageService
    {
        /// <summary>
        /// Connects to the ESB
        /// </summary>
        /// <param name="connectionString"></param>
        void Connect(string connectionString);

        /// <summary>
        /// Disconnects from ESB
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Creates message producer for endpoint
        /// </summary>
        /// <typeparam name="T">Type of message data</typeparam>
        /// <param name="endpoint">Endpoint name</param>
        /// <returns>Message producer instance</returns>
        IMessageProducer<T> CreateProducer<T>(string endpoint);

        /// <summary>
        /// Creates message consumer for endpoint
        /// </summary>
        /// <typeparam name="T">Type of message data</typeparam>
        /// <param name="endpoint">Endpoint name</param>
        /// <returns>Message consumer instance</returns>
        IMessageConsumer<T> CreateConsumer<T>(string endpoint);
    }
}