using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApiApplication.Models.UserActions
{
    public interface IUserCoordinator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userAccount"></param>
        void AddSimpleUser(User user, UserAccount userAccount);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        User RetrieveSimpleUser(string email);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User RetrieveSimpleUser(string email, string password);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateUser"></param>
        void EditSimpleUser(User updateUser);
    }
}