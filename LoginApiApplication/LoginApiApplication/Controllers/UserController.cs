using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoginApiApplication.Models.UserActions;

namespace LoginApiApplication.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserCoordinator _userCoordinator;

        public UserController(IUserCoordinator userCoordinator)
        {
            _userCoordinator = userCoordinator;
        }

        [HttpGet]
        public HttpResponseMessage Login(string username, string password)
        {
            var retrievedUser = _userCoordinator.RetrieveSimpleUser(username, password);
            return retrievedUser != null ? new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }

        [HttpGet]
        public User LoginAndGetUser(string username, string password)
        {
            return _userCoordinator.RetrieveSimpleUser(username, password);
        }

        public HttpResponseMessage UpdateUserDetails(User user)
        {
            var successfullUpdateOfUser = _userCoordinator.EditSimpleUserDetails(user);
            return successfullUpdateOfUser ? new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }

        [HttpPost]
        public HttpResponseMessage ChangePassword(string username, string existingPassword, string newPassword)
        {
            var successfullChange = _userCoordinator.ChangePassword(username, existingPassword, newPassword);
            return successfullChange ? new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }

        [HttpPost]
        public HttpResponseMessage SignUp(User user, UserAccount userAccount)
        {
            var successfullAddOfUser = _userCoordinator.AddSimpleUser(user, userAccount);
            return successfullAddOfUser
                ? new HttpResponseMessage(HttpStatusCode.OK)
                : new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }
    }
}
