using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessWeb.Pages
{
    public class RegisterPageModel : PageModel
    {
        [BindProperty]
        public RegisterModel registerModel { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            IUserRepository repository = new UserRepository();
            UserService service = new UserService(repository);

            if (ModelState.IsValid)
            {
                User registeredUser = new User(registerModel.Username, registerModel.Email, registerModel.FirstName, registerModel.LastName, UserType.USER, registerModel.Password);

                try
                {
                    service.RegisterUser(registeredUser);
                } catch (MySqlException ex)
                {
                    return Page();
                } catch (Exception es)
                {
                    return Page();
                }

                return RedirectToPage("LogIn");
            }

            return Page();
        }
    }
}
