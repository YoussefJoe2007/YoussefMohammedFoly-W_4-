using System.ComponentModel.DataAnnotations;

namespace YoussefMohammedFoly_W_4_.ViewModel
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
