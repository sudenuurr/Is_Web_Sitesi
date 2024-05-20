using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
           
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
            RuleFor(x => x.Website).NotEmpty().WithMessage("Web sitesi boş geçilemez");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon numarası boş geçilemez");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres boş geçilemez");
            //RuleFor(p => p.AppUser.Email).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . içermelidir");
            //RuleFor(x => x.AppUser.PasswordHash).NotEmpty().WithMessage("Şifre boş geçilemez");
            //RuleFor(p => p.AppUser.PasswordHash).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harfden oluşmalıdır.");
            //RuleFor(p => p.AppUser.PasswordHash).Matches(@"[a-z]+").WithMessage("Şifre en az bir küçük harfden oluşmalıdır.");
            //RuleFor(p => p.AppUser.PasswordHash).Matches(@"[0-9]+").WithMessage("Şifre en az bir rakamdan oluşmalıdır.");

        }
    }
}
