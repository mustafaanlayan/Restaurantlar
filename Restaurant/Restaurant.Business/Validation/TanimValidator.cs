using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Restaurant.Entites.Tables.Base;

namespace Restaurant.Business.Validation
{
   public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Tanim Bligisi 50 Karekterden Fazla Olamaz.").NotEmpty().WithMessage("Tanim Adı Boş Geçilemez");
        }
    }
}
