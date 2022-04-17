using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace SLFitness
{
    [Authorize (Roles = "COACH")]
    public class AdminPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
