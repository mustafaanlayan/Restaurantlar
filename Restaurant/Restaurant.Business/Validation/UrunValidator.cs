using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Restaurant.Entites.Tables;

namespace Restaurant.Business.Validation
{
   public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez").MaximumLength(50).WithMessage("Ürün Adı 50 Karekteri Geçemez");
            RuleFor(c => c.Barkod).MaximumLength(20).WithMessage("Barkod Bilgisi 20 Karekteri Geçemez");
        }
    }
}
