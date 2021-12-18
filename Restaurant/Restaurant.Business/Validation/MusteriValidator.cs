using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Restaurant.Entites.Tables.Base;

namespace Restaurant.Business.Validation
{
   public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı bilgisi 50 Karakterdenden Fazla Olamaz");
            RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Soyadı bilgisi 50 Karakterdenden Fazla Olamaz");
            RuleFor(c => c.KartNo).MaximumLength(20).WithMessage("Kart No bilgisi 20 Karakterdenden Fazla Olamaz");
        }
    }
}
