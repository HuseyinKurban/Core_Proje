using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_Proje.EntityLayer.Concrete;
using FluentValidation;

namespace Core_Proje.BusinessLayer.ValidationRules
{
   public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Proje Adını Boş Geçemezsiniz");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Proje Resmini Boş Geçemezsiniz");
            RuleFor(x=>x.ImageUrl2).NotEmpty().WithMessage("Proje Resmini Boş Geçemezsiniz");
            RuleFor(x=>x.Price).NotEmpty().WithMessage("Proje Fiyatını Boş Geçemezsiniz");
            RuleFor(x=>x.Value).NotEmpty().WithMessage("Proje Oranını Boş Geçemezsiniz");
            RuleFor(x=>x.Name).MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakter Olmalıdır");
            RuleFor(x=>x.Name).MaximumLength(100).WithMessage("Proje Adı En Fazla 100 Karakter Olmalıdır");
        }
    }
}
