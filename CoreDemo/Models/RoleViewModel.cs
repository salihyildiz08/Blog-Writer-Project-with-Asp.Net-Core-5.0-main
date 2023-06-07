using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage="lütfen rol adı gir")]
        public string Name { get; set; }
    }
}
