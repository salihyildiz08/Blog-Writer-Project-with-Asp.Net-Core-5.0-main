using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="place user name entry")]
        public string username { get; set; }
        [Required(ErrorMessage = "place password entry")]
        public string password { get; set; }
    }
}
