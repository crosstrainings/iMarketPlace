using System.ComponentModel.DataAnnotations;
namespace MarketPlace.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "required")]
        public string Password { get; set; }
    }
}