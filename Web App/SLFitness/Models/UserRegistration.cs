﻿using System.ComponentModel.DataAnnotations;

namespace SLFitness.Models
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
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Try again !")]
        public string ConfirmPassword { get; set; }

    }
}