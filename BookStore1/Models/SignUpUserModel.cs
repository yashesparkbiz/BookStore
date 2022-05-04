namespace BookStore1.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "please enter your first name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "please enter a strong password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password doesn't match")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "please confirm your password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
