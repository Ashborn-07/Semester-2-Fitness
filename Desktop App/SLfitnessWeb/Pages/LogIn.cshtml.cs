using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BusinessLogicLayer;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using DataAccessLayer;

namespace SLfitnessWeb.Pages
{
    public class LogInModel : PageModel
    {
        private UserService service;
        [BindProperty]
        public BusinessLogicLayer.LogInModel UserModel { get; set; }

        public void OnGet()
        {
            if (User.Claims != null)
            {
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
        }

        public IActionResult OnPost()
        {
            IUserRepository repository = new UserRepository();
            service = new UserService(repository);

            if (ModelState.IsValid)
            {
                User user = service.UserDataValidation(UserModel.Username, UserModel.Password);
                if (user != null)
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                    claims.Add(new Claim("id", user.Id.ToString()));
                    claims.Add(new Claim(ClaimTypes.Role, user.Type.ToString()));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("Index");
                }
            }

            return Page();
        }
    }
}
