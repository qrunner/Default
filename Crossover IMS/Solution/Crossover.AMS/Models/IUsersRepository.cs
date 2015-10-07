namespace Crossover.AMS.Models
{
    /// <summary>
    /// Repository of user account information
    /// </summary>
    public interface IUsersRepository
    {
        /// <summary>
        /// Retrieves user information from storage
        /// </summary>
        /// <param name="identity">Identity of user</param>
        /// <returns>Info of user with given identity</returns>
        UserInfo GetUserInfo(string identity);
    }
}