using System;
using System.Text;

namespace Mcs.Server
{
    public static class Roles
    {
        public const string Editor = "Editor";
        public const string Viewer = "Viewer";
        public const string Supervisor = "Supervisor";
        public const string EditorSupervisor = "Editor, Supervisor";
        public static string Merge(params string[] roles)
        {
            if (roles == null) throw new ArgumentNullException("Требуется указать список ролей");
            if (roles.Length == 0) throw new ArgumentException("Список ролей не может быть пустым");

            StringBuilder retval = new StringBuilder();
            foreach (var role in roles)
            {
                if (string.IsNullOrWhiteSpace(role)) throw new ArgumentException("Одна из указанных ролей является пустой строкой");

                retval.AppendFormat("{0}, ", role);
            }

            retval.Remove(retval.Length - 3, 2);

            return retval.ToString();
        }
    }
}