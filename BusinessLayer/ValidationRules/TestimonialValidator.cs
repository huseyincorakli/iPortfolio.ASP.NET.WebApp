using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.TestimoNameSurname).NotEmpty().WithMessage("Ad Soyad Boş geçilemez");
            RuleFor(x => x.TestimoNameSurname).MaximumLength(60).WithMessage("Ad Soyad en fazla 60 karakter olmalı");
            RuleFor(x => x.TestimoNameSurname).MinimumLength(2).WithMessage("Ad Soyad en az 2 karakter olmalı");
            RuleFor(x => x.TestimoComment).NotEmpty().WithMessage("Yorum boş geçilemez");
            RuleFor(x => x.TestimoComment).MaximumLength(200).WithMessage("Yorum en fazla 200 karakterden oluşmalı");
            RuleFor(x => x.TestimoComment).MinimumLength(20).WithMessage("Yorum en az 20 karakterden oluşmalı");
            RuleFor(x => x.TestimoImageUrl).NotEmpty().WithMessage("Url gereklidir.Boş geçilemez");
            RuleFor(x => x.TestimoImageUrl).MaximumLength(200).WithMessage("Url en fazla 200 karakterden oluşmalı");
            RuleFor(x => x.TestimoTitle).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.TestimoTitle).MaximumLength(30).WithMessage("En fazla 30 karakter olmalı");
        }
    }
}
