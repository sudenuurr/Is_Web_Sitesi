using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message2>
    {
        public MessageValidator()
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş geçilemez");
            RuleFor(x => x.Details).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.Details).MinimumLength(20).WithMessage("İçerik en az 20 karakter olmalı");

        }
    }
}
