using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SLFitness.Models;
using SLFitness.Logic;

namespace SLFitness.Pages
{
    public class RegisterModel : PageModel
    {
        public string PageTitle { get; private set; }

        [BindProperty]
        public Register Registration { get; set; }

        UserLogic logic;

        public RegisterModel()
        {
            PageTitle = "Sign Up";
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            logic = new UserLogic();

            if(ModelState.IsValid)
            {
                //TODO
                if (logic.CheckUserInputRegistration(Registration.Username, Registration.Password, Registration.Email, Registration.FirstName, Registration.LastName))
                {
                    return RedirectToPage("SignIn");
                }
            }

            return Page();
        }
    }
}
