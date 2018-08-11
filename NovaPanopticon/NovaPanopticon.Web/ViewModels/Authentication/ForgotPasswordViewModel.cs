using System.ComponentModel.DataAnnotations;

namespace NovaPanopticon.Web.ViewModels.Authentication
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}