using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class LinkValidator : AbstractValidator<ContactLink>
    {
        public LinkValidator()
        {
            RuleFor(x => x.LinkName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.LinkName).MaximumLength(30).WithMessage("en fazla 30 karakter olmalı");
            RuleFor(x => x.LinkUrl).NotEmpty().WithMessage("Url boş geçilemez, Bir Url'e sahip değilseniz '#' yazınız. ");
            RuleFor(x => x.LinkUrl).MaximumLength(250).WithMessage("en fazla 250 karakter olmalı");
           
        }
    }
}
