using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{ 
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
