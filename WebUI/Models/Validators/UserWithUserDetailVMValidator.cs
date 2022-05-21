using FluentValidation;
using WebUI.ViewModels;

namespace WebUI.Models.Validators
{
    public class UserWithUserDetailVMValidator: AbstractValidator<UserWithUserDetailVM>
    {
        public UserWithUserDetailVMValidator()
        {
            RuleFor(a => a.User.UserName).NotEmpty().WithMessage("Lütfen isim giriniz");
            RuleFor(a => a.User.UserEMail).Matches(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$").WithMessage("Geçerli bir mail adresi girin")
                .NotEmpty().WithMessage("Lütfen mail adresi girin");
            RuleFor(a => a.Password.PasswordContent).Matches(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$").WithMessage("Kurallara uygun şifre belirleyin")
                .NotEmpty().WithMessage("Lütfen şifre girin");
        }
    }
}
