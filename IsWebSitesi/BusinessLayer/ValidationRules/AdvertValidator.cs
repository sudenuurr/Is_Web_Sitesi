using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdvertValidator:AbstractValidator<Advert>
    {
        public AdvertValidator()
        {
            RuleFor(x => x.Department).NotEmpty().WithMessage("Departman boş geçilemez");
            RuleFor(x => x.JobType).NotEmpty().WithMessage("Çalışma şekli boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama şekli boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Açıklama en az 20 karakter olmalı");
            RuleFor(x => x.Required).NotEmpty().WithMessage("Gereklilikler boş geçilemez");
            RuleFor(x => x.Experience).NotEmpty().WithMessage("Deneyim boş geçilemez");

        }


    }
}
