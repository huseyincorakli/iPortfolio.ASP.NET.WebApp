using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public  class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.SkillDegree).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.SkillDegree).GreaterThan(0).WithMessage("Sıfırdan  büyük olmalı");
            RuleFor(x => x.SkillName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.SkillName).MaximumLength(50).WithMessage("En fazla 50 karakter olmalı");
        }
    }
}
