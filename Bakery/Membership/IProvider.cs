namespace Membership
{
    /// <summary>
    /// Провайдер службы членства
    /// </summary>
    internal interface IProvider
    {
        /// <summary>
        /// Проверяет принадлежность пользователя к группе
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roles"></param>
        /// <returns></returns>
        bool IsUserInRoles(IUserIdentity user, params string[] roles);

        /// <summary>
        /// Выполняет аутентификацию пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Токен пользователя</returns>
        IUserIdentity Auth(string login, string password);
    }
}