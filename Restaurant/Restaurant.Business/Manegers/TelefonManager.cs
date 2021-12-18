using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Business.Services;
using Restaurant.Entites.Tables.Base;
using Restaurantt.DataAcces.UnitOfWork;

namespace Restaurant.Business.Manegers
{
   public class TelefonManager:BaseManeger<Telefon>,ITelefonService
    {
        public TelefonManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
