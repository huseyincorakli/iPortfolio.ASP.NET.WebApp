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
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Boş geçilemez");
        }

    }
}
