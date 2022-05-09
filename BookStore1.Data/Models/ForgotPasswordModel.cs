using System.ComponentModel.DataAnnotations;

namespace BookStore1.Data.Models
{
    public class ForgotPasswordModel
    {
        [Required, EmailAddress, Display(Name ="Registered email Address")]
        public string Email { get; set; }
        public bool EmailSent { get; set; }
    }
}
