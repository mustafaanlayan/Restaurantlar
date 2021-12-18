using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Restaurant.Entites.Tables.Base;

namespace Restaurant.Business.Validation
{
   public class PorsiyonValidator:AbstractValidator<Porsiyon>
    {
        public PorsiyonValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Porsiyon Adı 50 Karekterden Fazla Olamaz");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Bilgisi Aralık Dışında");
            RuleFor(c => c.EkMalzemeCarpan).ScalePrecision(2, 4).WithMessage("Çarpan Bilgisi Aralık Dışında");
        }
    }
}
