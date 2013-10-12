using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApiApplication.Models
{
    public class AddUser
    {
        public static void AddSimpleUser(User user, UserAccount userAccount)
        {
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
                    Password = userAccount.Password,
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