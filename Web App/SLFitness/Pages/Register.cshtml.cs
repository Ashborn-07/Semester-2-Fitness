using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace SLFitness.Pages
{
    public class RegisterModel : PageModel
    {
        public string PageTitle { get; private set; }

        [BindProperty]
        public UserRegistration Registration { get; set; }

        public RegisterModel()
        {
            PageTitle = "Sign Up";
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                //TODO
                return RedirectToPage();
            }

            return Page();
        }
    }
}
