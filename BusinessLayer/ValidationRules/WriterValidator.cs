using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar ad soyad kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mail kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Yazar mail kısmı format hatali");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifre kısmı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın");
            RuleFor(x => x.WriterPassword).Must(checkPasswordRules).WithMessage("Lütfen en az bir büyük harf,bir küçük harf ve bir sayı kullanınız");

        }

        private bool checkPasswordRules(string arg)
        {
            var m = Regex.Match(arg, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,})");
            return m.Success ? true : false;
        }
    }
}
