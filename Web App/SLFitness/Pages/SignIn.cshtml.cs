using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SLFitness.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace SLFitness.Pages.Shared
{
    public class LogInModel : PageModel
    {
        public string PageTitle { get; private set; }

        [BindProperty]
        public SignIn signIn { get; set; }

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
               User user = signIn.AttemptSignIn();
                if (user != null)
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim("id", user.Id.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                    claims.Add(new Claim(ClaimTypes.Role, user.UserType));

                    var ClaimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(ClaimsIdentity));
                    Redirect("Index");
                }
            }

            return Page();
        }
    }
}
