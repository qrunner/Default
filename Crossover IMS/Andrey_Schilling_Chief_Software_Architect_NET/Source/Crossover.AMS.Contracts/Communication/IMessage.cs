using System;

namespace Crossover.AMS.Contracts.Communication
{
    /// <summary>
    /// Base communication message
    /// </summary>
    public interface IMessage
    {
        long Id { get; }

        string Text { get; set; }

        string[] Attachments { get; }

        DateTime Sended { get; }

        string SenderSid { get; }
    }
}