using ETicaretEntities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace WebUI.ViewModels
{
    public class LogInVM
    {
        public User User { get; set; } = default!;
        public UserDetail UserDetail { get; set; } = default!;
        [Required]
        public Password Password { get { return GetPassword(); } set { } }
        public Password GetPassword()
        {
            if (User.Passwords.OrderByDescending(a => a.PasswordDate).FirstOrDefault() != null)
            {
                return Password;
            }
            else
                return default!;
        }
    }
}
