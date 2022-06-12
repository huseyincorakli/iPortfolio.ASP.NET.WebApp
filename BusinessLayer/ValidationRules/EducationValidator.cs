using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class EducationValidator:AbstractValidator<EducationInfo>
    {
        public EducationValidator()
        {
            RuleFor(x => x.EduDescription).NotEmpty().WithMessage("Açıklama  boş geçilemez");
            RuleFor(x => x.EduDescription).MinimumLength(50).WithMessage("Açıklama en az 50 karakter olmalı");
            RuleFor(x => x.EduDescription).MaximumLength(200).WithMessage("Açıklama adı en fazla 200 karakter olmalı");
            RuleFor(x => x.EduHeading).NotEmpty().WithMessage("Başlık  boş geçilemez");
            RuleFor(x => x.EduHeading).MinimumLength(25).WithMessage("Başlık en az 25 karakter olmalı");
            RuleFor(x => x.EduHeading).MaximumLength(50).WithMessage("Başlık adı en fazla 50 karakter olmalı");
            RuleFor(x => x.EduSumaryHead).NotEmpty().WithMessage("Özet  boş geçilemez");
            RuleFor(x => x.EduSumaryHead).MinimumLength(25).WithMessage("Özet en az 25 karakter olmalı");
            RuleFor(x => x.EduSumaryHead).MaximumLength(50).WithMessage("Özet  en fazla 50 karakter olmalı");
            RuleFor(x => x.EduTime).NotEmpty().WithMessage("Açıklama  boş geçilemez");
            
            
        }
    }
}
