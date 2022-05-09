using System.ComponentModel.DataAnnotations;
namespace BookStore1.Data.Models
{
    public class SignInModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="RememberMe")]
        public bool RememberMe { get; set; }
    }
}
