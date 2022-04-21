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
            IUserRepository repository = new UserRepository();
            UserService service = new UserService(repository);

            var id = User.Claims.Where(c => c.Type == "id")
                   .Select(c => c.Value).SingleOrDefault();

            User user = service.GetUserById(Convert.ToInt32(id));

            profileModelLogic = new ProfileModelLogic() { FirstName = user.FirstName, LastName = user.LastName, Email = user.Email };
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
    }
}
