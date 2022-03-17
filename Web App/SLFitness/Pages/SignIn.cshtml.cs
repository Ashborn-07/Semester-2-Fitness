using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SLFitness.Models;

namespace SLFitness.Pages.Shared
{
    public class LogInModel : PageModel
    {
        public string PageTitle { get; private set; }

        [BindProperty]
        public UserSignIn UserSignIn { get; set; }

        DataAccess data;

        public LogInModel()
        {
            PageTitle = "Sign Up";
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                data = new DataAccess();
                int i = data.CheckUserCreadentialsAndReturnID(UserSignIn.Username, UserSignIn.Password);
                if (i != -1)
                {
                    return RedirectToPage("Index", new { id =  i});
                }
                //Display wrong credentials
            }

            return Page();
        }
    }
}
