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
   public class TanimManeger:BaseManeger<Tanim>,ITanimServices
    {
        public TanimManeger(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
