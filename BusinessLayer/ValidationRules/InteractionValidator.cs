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
            RuleFor(x => x.InteractionName).NotEmpty().WithMessage("Etkileşim Adı:  boş geçilemez");
            RuleFor(x => x.InteractionValue).NotEmpty().WithMessage("Değer  boş geçilemez");
            
        }
        
    }
}
