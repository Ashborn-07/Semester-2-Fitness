using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SLfitnessWeb.Pages
{
    public class ErrorPageModel : PageModel
    {
        public string Error { get; set; }

        public void OnGet()
        {
        }
    }
}
