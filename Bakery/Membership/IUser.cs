namespace Membership
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public interface IUser
    {
        string Login { get; }

        /// <summary>
        /// Полное имя
        /// </summary>
        string FullName { get; }
    }
}