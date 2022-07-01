using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceInfoValidator: AbstractValidator<ExperienceInfo>
    {
        public ExperienceInfoValidator()
        {
            RuleFor(x => x.ExperienceSumaryHead).NotEmpty().WithMessage("boş geçilemez");
            RuleFor(x => x.ExperienceSumaryHead).MaximumLength(50).WithMessage("en fazla 50 karakter olmalı");
            RuleFor(x => x.ExperienceDescription).NotEmpty().WithMessage("boş geçilemez");
            RuleFor(x => x.ExperienceDescription).MaximumLength(200).WithMessage("en fazla 200 karakter olmalı");
            RuleFor(x => x.ExperienceDescription).MinimumLength(25).WithMessage("en az 25 karakter olmalı");
            RuleFor(x => x.ExperienceHeading).NotEmpty().WithMessage("boş geçilemez");
            RuleFor(x => x.ExperienceHeading).MaximumLength(50).WithMessage("en fazla 50 karakter olmalı");
            RuleFor(x => x.ExperienceHeading).MinimumLength(15).WithMessage("en az 15 karakter olmalı");
            RuleFor(x => x.ExperienceTime).NotEmpty().WithMessage("boş geçilemez");
         

        }
    }
}
