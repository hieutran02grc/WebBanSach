using System.ComponentModel.DataAnnotations;

namespace hieutran02grc.WebBanSach.Models
{
    public class SignInModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
