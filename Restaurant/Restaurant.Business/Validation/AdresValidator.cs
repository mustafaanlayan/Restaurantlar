using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Restaurant.Entites.Tables;

namespace Restaurant.Business.Validation
{
   public class AdresValidator:AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(c => c.Il).MaximumLength(30).WithMessage("Il Bilgisi için 30 Karakterden Büyük Olamaz");
            RuleFor(c => c.Ilce).MaximumLength(30).WithMessage("Ilce Bilgisi için 30 Karakterden Büyük Olamaz");
            RuleFor(c => c.Adresi).MaximumLength(30).WithMessage("Adres Bilgisi için 100 Karakterden Büyük Olamaz");
            RuleFor(c => c.Semt).MaximumLength(30).WithMessage("Semt Bilgisi için 300 Karakterden Büyük Olamaz");
        }
    }
}
