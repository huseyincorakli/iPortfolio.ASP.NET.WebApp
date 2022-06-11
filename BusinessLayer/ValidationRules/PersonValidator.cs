using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.PersonNameSurname).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonAboutBody).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonAboutHead).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonBirthday).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonCity).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonEmail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonExperience).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonGsm).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonJob).NotEmpty().WithMessage("Boş geçilemez");
           
        }
    }
}
