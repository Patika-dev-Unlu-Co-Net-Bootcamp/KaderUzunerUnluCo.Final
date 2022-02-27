using FluentValidation;
using ProductUnluCo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductUnluCo.Application.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().NotNull().WithMessage("Ad & Soyad boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail boş geçilemez.");
            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Ad & Soyad minimum 2 karakter olmalı");
            RuleFor(x => x.PasswordHash).MinimumLength(8).WithMessage("Şifre en az 8 karakter olabilir");
            RuleFor(x => x.PasswordHash).MaximumLength(20).WithMessage("Şifre en fazla 20 karakter olabilir");
            RuleFor(x => x.PasswordHash).Must(IsPasswordValid).WithMessage("Parolanızda en az bir küçük harf bir büyük harf ve rakam içermelidir.");
        }
        private bool IsPasswordValid(string arg)
        {
            try
            {
              Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
