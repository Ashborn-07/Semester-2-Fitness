using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessWeb.Pages
{
    [Authorize(Roles = "COACH")]
    public class MembersPageModel : PageModel
    {

        private UserService service;
        public List<User> users;

        public void OnGet()
        {
            IUserRepository repository = new UserRepository();
            service = new UserService(repository);

            users = service.GetUsersInList();
        }
    }
}
