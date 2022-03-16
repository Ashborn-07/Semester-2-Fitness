using System.ComponentModel.DataAnnotations;

namespace SLFitness.Pages
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Your first name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Your last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage = "Password must be at least 5 symbols")]
        public string Password { get; set; }
        [Required(ErrorMessage = "You must repeat your password")]
        [Compare("Password", ErrorMessage = "Confirm password deosn't match, Try again !")]
        public string ConfirmPassword { get; set; }

        public UserRegistration()
        {

        }

        public UserRegistration(string username, string email, string firstName, string lastName, string password, string confirmPassword)
        {
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
