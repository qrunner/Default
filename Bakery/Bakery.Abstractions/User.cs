using System.Collections.Generic;
using System.Linq;

namespace Bakery.Model
{
    /// <summary>
    /// Пользователь системы
    /// </summary>
    public class User : NamedEntity
    {
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Роли пользователя
        /// </summary>
        public virtual ICollection<UserRole> Roles { get; set; }

        /// <summary>
        /// Проверяет принадлежность пользователя роли
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool IsInRole(UserRole role)
        {
            return Roles.Any(x => x == role);
        }
    }
}