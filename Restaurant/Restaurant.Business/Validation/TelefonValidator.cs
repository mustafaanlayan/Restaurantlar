using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Restaurant.Entites.Tables.Base;

namespace Restaurant.Business.Validation
{
   public class TelefonValidator:AbstractValidator<Telefon>
    {
        public TelefonValidator()
        {
            RuleFor(c => c.Telefonu).MaximumLength(20).WithMessage("Telefon Bilgisi 20 Karakterden Fazla Olamaz");
            RuleFor(c => c.TelefonTip).MaximumLength(20).WithMessage("Telefon Bilgisi 20 Karakterden Fazla Olamaz");
        }
    }
}
