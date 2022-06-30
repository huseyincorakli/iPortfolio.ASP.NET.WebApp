using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GalleryValidator : AbstractValidator<Gallery>
    {
        public GalleryValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
            RuleFor(x => x.Description).MaximumLength(100).WithMessage("Açıklama en fazla 100 karakter olmalı.");
            RuleFor(x => x.Description).MinimumLength(2).WithMessage("Açıklama en az 2 karakter olmalı.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Url boş geçilemez");
            RuleFor(x => x.ImageUrl).MinimumLength(3).WithMessage("Url en az 3 karakter olmalı");
            RuleFor(x => x.ImageUrl).MaximumLength(200).WithMessage("Url en fazla 200 karakter olmalı");
        }

    }
}
