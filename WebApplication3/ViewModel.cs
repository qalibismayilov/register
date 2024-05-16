using System.ComponentModel.DataAnnotations;

namespace YourProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

      
    }
}
