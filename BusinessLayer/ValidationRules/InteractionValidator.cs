using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class InteractionValidator: AbstractValidator<Interaction>
    {
        public InteractionValidator()
        {
            RuleFor(x => x.InteractionDiscription).NotEmpty().WithMessage("Etkileşim Açıklama boş geçilemez");
            RuleFor(x => x.InteractionDiscription).MaximumLength(50).WithMessage("Etkileşim Açıklaması en fazla 50 karakter olmalı");
            RuleFor(x => x.InteractionDiscription).MinimumLength(3).WithMessage("Etkileşim Açıklaması en az 3 karakter olmalı");
            RuleFor(x => x.InteractionName).NotEmpty().WithMessage("Etkileşim adı  boş geçilemez");
            RuleFor(x => x.InteractionName).MaximumLength(20).WithMessage("Etkileşim adı en fazla 20 karakter olmalı");
            RuleFor(x => x.InteractionName).MinimumLength(2).WithMessage("Etkileşim adı  az 2 karakter olmalı");
            RuleFor(x => x.InteractionValue).NotEmpty().WithMessage("Değer  boş geçilemez");
            
        }
        
    }
}
