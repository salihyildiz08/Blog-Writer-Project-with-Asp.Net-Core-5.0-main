
using System.ComponentModel.DataAnnotations;


namespace CoreDemo.Models
{
    public class UserSingnUpViewModel
    {
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage = "Place Name Surname enter")]
        public string NameSurname { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Place Name Surname enter")]
        public string Password { get; set; }
        [Display(Name = "ConfirmPassword")]
        [Compare("Password",ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Place mail enter")]
        public string Mail { get; set; }
        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Place UserName enter")]
        public string UserName { get; set; }

    }
}
