using System.ComponentModel.DataAnnotations;

namespace SLFitness.Models
{
    public class UserSignIn
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage = "Password must be at least 5 symbols")]
        public string Password { get; set; }
    }
}
