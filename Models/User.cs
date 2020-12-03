using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models{
    public class User{
        [Display(Name = "", Prompt = "First Name")]
        [Required(ErrorMessage = "First name is required.")]
        [MinLength(2, ErrorMessage = "That's too short.")]
        public string FirstName { get; set; }

        [Display(Name = "", Prompt = "Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        [MinLength(2, ErrorMessage = "That's too long.")]
        public string LastName { get; set; }

        [Display(Name = "", Prompt = "Age")]
        [Required(ErrorMessage = "Age is missing")]
        [MinLength(2)]
        public string Age { get; set; }

        [Display(Name = "", Prompt = "Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "", Prompt = "Password")]
        [Required]
        // [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}