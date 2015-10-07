namespace Crossover.AMS.Communication.Chat.Entities
{
    public class SiteUser
    {
        public SiteUser(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }
        
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }
    }
}