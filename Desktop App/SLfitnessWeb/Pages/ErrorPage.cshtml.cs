using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SLfitnessWeb.Pages
{
    public class ErrorPageModel : PageModel
    {
        public string Error { get; set; }
        public string Code { get; set; }

        public void OnGet(string code)
        {
            Code = code;
        }
    }
}
