using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator:AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Sifre  boş geçilemez");
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalı");
            RuleFor(x => x.Password).MaximumLength(100).WithMessage("Şifre en fazla 100 karakter olmalı");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalı");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Kullanıcı adı en fazla 20 karakter olmalı");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
           
        }
    }
}
