using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using DataAccessLayer;
using BusinessLogicLayer;
using Microsoft.AspNetCore.Authorization;

namespace SLfitnessWeb.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public ProfileModelLogic profileModelLogic { get; set; }
      
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                User updatedUser = new User(profileModelLogic.FirstName, profileModelLogic.LastName, profileModelLogic.Email);
                IUserRepository repository = new UserRepository();
                UserService service = new UserService(repository);

                var id = User.Claims.Where(c => c.Type == "id")
                  .Select(c => c.Value).SingleOrDefault();

                service.UpdateUserWeb(updatedUser, Convert.ToInt32(id));
            }

            return Page();
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// not best way to implement but only that i came up with no breaking the website /////
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        public string GetFirstName()
        {
            IUserRepository repository = new UserRepository();
            UserService service = new UserService(repository);

            var id = User.Claims.Where(c => c.Type == "id")
                   .Select(c => c.Value).SingleOrDefault();

            User user = service.GetUserById(Convert.ToInt32(id));

            return user.FirstName;
        }

        public string GetEmail()
        {
            IUserRepository repository = new UserRepository();
            UserService service = new UserService(repository);

            var id = User.Claims.Where(c => c.Type == "id")
                   .Select(c => c.Value).SingleOrDefault();

            User user = service.GetUserById(Convert.ToInt32(id));

            return user.Email;
        }

        public string GetLastName()
        {
            IUserRepository repository = new UserRepository();
            UserService service = new UserService(repository);

            var id = User.Claims.Where(c => c.Type == "id")
                   .Select(c => c.Value).SingleOrDefault();

            User user = service.GetUserById(Convert.ToInt32(id));

            return user.LastName;
        }
    }
}
