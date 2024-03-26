using System.ComponentModel.DataAnnotations;

namespace AceCorpCustomIdentity.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Username is required.")]
        public required string Username { get; set; }
        [Required(ErrorMessage ="Password is required.")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
