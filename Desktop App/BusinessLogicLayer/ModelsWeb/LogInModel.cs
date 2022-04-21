using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer
{
    public class LogInModel
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Minimum Lenght is 3 characters")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(3, ErrorMessage = "Minimum Lenght is 3 characters")]
        public string? Password { get; set; }
    }
}
