using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Restaurant.Entites.Tables.Base;

namespace Restaurant.Business.Validation
{
   public class EkMalzemeValidator:AbstractValidator<EkMalzeme>
    {
        public EkMalzemeValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Adı Boş  Olamaz");
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Porsiyon Adı 50 Karekterden Fazla Olamaz");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Bilgisi Aralık Dışında");
        }
    }
}
