using System.Collections.Generic;

namespace Crossover.AMS.Contracts.Notification
{
    /// <summary>
    /// Service for mass notification with different channels
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Notify by phones with voice message
        /// </summary>
        /// <param name="contactList">Contacts (phones)</param>
        /// <param name="message">Voice message</param>
        /// <returns>Notification result</returns>
        INotificationTask NotifyVoice(IEnumerable<IContact> contactList, IVoiceNotificationMessage message);

        /// <summary>
        /// Notify by phones with SMS
        /// </summary>
        /// <param name="contactList">Contacts (phones)</param>
        /// <param name="message">SMS message</param>
        /// <returns>Notification result</returns>
        INotificationTask NotifySms(IEnumerable<IContact> contactList, ITextNotificationMessage message);

        /// <summary>
        /// Notify by e-mail
        /// </summary>
        /// <param name="contactList">Contacts (e-mails)</param>
        /// <param name="message">E-mail message</param>
        /// <returns>Notification result</returns>
        INotificationTask NotifyEmail(IEnumerable<IContact> contactList, IMailNotificationMessage message);

        /// <summary>
        /// Notify to social networks
        /// </summary>
        /// <param name="contactList">Contacts (community addresses)</param>
        /// <param name="message">Hypertext message</param>
        /// <returns>Notification result</returns>
        INotificationTask NotifySocial(IEnumerable<IContact> contactList, IMailNotificationMessage message);
    }
}