using System.ComponentModel.DataAnnotations;

namespace GuestBookGit.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Логин обязателен.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пароль обязателен.")]
        public string Password { get; set; }
    }
}
