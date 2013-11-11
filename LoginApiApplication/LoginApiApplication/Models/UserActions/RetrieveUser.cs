using System.Linq;

namespace LoginApiApplication.Models.UserActions
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

        public static User RetrieveSimpleUser(string email, string password)
        {
            using (var db = new UserContext())
            {
                var existingUser = from user in db.Users where user.Email.Equals(email) select user;

                foreach (var user in existingUser)
                {
                    var isPasswordValid = PasswordUtility.PasswordHash.ValidatePassword(password, user.UserAccounts.First().Password);
                    if (isPasswordValid)
                    {
                        return user;
                    }
                }
            }
            return null;
        }
    }
}