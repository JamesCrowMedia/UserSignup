using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Username can not be more than 25 characters or less than 5.")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(64, MinimumLength = 6, ErrorMessage = "Username can not be more than 25 characters or less than 5.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string Verify { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        private class ErrorMessageAttribute : Attribute
        {
        }
    }
}
