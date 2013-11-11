using System;

namespace LoginApiApplication.Models.UserActions
{
    public class AddUser
    {
        public static void AddSimpleUser(User user, UserAccount userAccount)
        {
            var existingUser = RetrieveUser.RetrieveSimpleUser(user.Email);

            if (existingUser != null)
            {
                throw new Exception("This user with the assosiated Email Address already exists");
            }

            using (var db = new UserContext())
            {
                var addUser = new User
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    Address = user.Address,
                    Email = user.Email,
                    Company = user.Company,
                    PhoneNumber = user.PhoneNumber,
                };

                var addUserAccount = new UserAccount()
                {
                    IsAdmin = userAccount.IsAdmin,
                    ConfirmedEmail = userAccount.ConfirmedEmail,
                    IsAuthorized = userAccount.IsAuthorized,
                    LastLogin = userAccount.LastLogin,
                    SignupDate = userAccount.SignupDate,
                    Locked = userAccount.Locked,
                    LoginAttempts = userAccount.LoginAttempts,
                    Username = userAccount.Username,
                    Password = PasswordUtility.PasswordHash.CreateHash(userAccount.Password),
                    UserAccountId = userAccount.UserAccountId,
                    UserUserId = user.UserId,
                };

                db.Users.Add(addUser);
                db.UserAccounts.Add(addUserAccount);
                db.SaveChanges();
            }
        }
    }
}