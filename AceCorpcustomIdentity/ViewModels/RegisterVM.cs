using System.ComponentModel.DataAnnotations;

namespace AceCorpCustomIdentity.ViewModels
{
    public class RegisterVM
    {
        public required string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        public required string Password { get; set; }
        [Compare("Password", ErrorMessage ="Passwords don't match.")]
        public required string ConfirmPassword { get; set; }
        public required string Address { get; set; }
    }
}
