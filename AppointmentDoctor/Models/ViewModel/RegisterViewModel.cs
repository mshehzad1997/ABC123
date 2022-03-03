using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentDoctor.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100,ErrorMessage ="the {0} must be {2} character long",MinimumLength =6)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="the password and confirmation password not be match")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name = "RoleName")]
        public string RoleName { get; set; }
    }
}
