using System.Linq;

namespace LoginApiApplication.Models
{
    public class RetrieveUser
    {
        public static User RetrieveSimpleUser(string email)
        {
            using (var db = new UserContext())
            {
                var existingUser = from user in db.Users where user.Email.Equals(email) select user;
                
                foreach (var user in existingUser)
                {
                    return user;
                }           
            }
            return null;
        }
    }
}