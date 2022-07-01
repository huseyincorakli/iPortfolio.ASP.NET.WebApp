using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
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
            RuleFor(x => x.Intro).NotEmpty().WithMessage("Tanıtma boş geçilemez");
            RuleFor(x => x.Intro).MaximumLength(400).WithMessage("Tanıtma en fazla 400 karakterden oluşabilir");
            RuleFor(x => x.Intro).MinimumLength(40).WithMessage("Tanıtma en az 40 karakterden oluşabilir");
            RuleFor(x => x.FreelanceStatus).MinimumLength(1).WithMessage("Çalışma statüsü en az 1 karakterden oluşabilir");
            RuleFor(x => x.FreelanceStatus).MaximumLength(20).WithMessage("Çalışma statüsü en fazla 20 karakterden oluşabilir");
            RuleFor(x => x.FreelanceStatus).NotEmpty().WithMessage("Çalışma statüsü boş geçilemez");
            RuleFor(x => x.PersonNameSurname).MaximumLength(50).WithMessage("Ad Soyad en fazla 50 karakter olmalı");
            RuleFor(x => x.PersonAboutBody).MinimumLength(2).WithMessage("Ad Soyad en az 2 karakter olmalı");
            RuleFor(x => x.PersonAboutHead).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonAboutHead).MaximumLength(80).WithMessage("En fazla 80 karakter olmalı");
            RuleFor(x => x.PersonAboutHead).MinimumLength(25).WithMessage("En az 25 karakter olmalı");
            RuleFor(x => x.PersonBirthday).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonCity).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonCity).MaximumLength(50).WithMessage(" Şehir adı en fazla 50 karakter olmalı");
            RuleFor(x => x.PersonCity).MinimumLength(3).WithMessage("Şehir adı en az 3 karakter olmalı");
            RuleFor(x => x.PersonEmail).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonEmail).EmailAddress().WithMessage("Geçerli bir  email adresi olmalı");
            RuleFor(x => x.PersonExperience).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonExperience).MaximumLength(50).WithMessage("En fazla 50 karakter olmalı");
            RuleFor(x => x.PersonExperience).MinimumLength(5).WithMessage("En az 5 karakter olmalı");
            RuleFor(x => x.PersonGsm).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonGsm).MaximumLength(50).WithMessage("En fazla 50 karakter olmalı");
            RuleFor(x => x.PersonGsm).MinimumLength(10).WithMessage("En az 10 karakter olmalı");
            RuleFor(x => x.PersonJob).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.PersonJob).MaximumLength(50).WithMessage("En fazla 50 karakter olmalı");
           
        }
    }
}
