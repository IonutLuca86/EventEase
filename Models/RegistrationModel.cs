using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(100, MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        // [Required]
        // [StringLength(100, MinimumLength = 6)]
        // public string Password { get; set; }

        // [Required]
        // [Compare("Password", ErrorMessage = "Passwords do not match.")]
        // public string ConfirmPassword { get; set; }


        // Override Equals to compare based on Username and Email
        public override bool Equals(object obj)
        {
            if (obj is RegistrationModel other)
            {
                return string.Equals(Username, other.Username, StringComparison.OrdinalIgnoreCase) &&
                       string.Equals(Email, other.Email, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        // Override GetHashCode to generate a hash code based on Username and Email
        public override int GetHashCode()
        {
            return HashCode.Combine(Username?.ToLower(), Email?.ToLower());
        }
    }
}
