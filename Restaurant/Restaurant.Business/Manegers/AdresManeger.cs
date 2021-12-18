using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Business.Services;
using Restaurant.Entites.Tables;
using Restaurantt.DataAcces.UnitOfWork;

namespace Restaurant.Business.Manegers
{
   public class AdresManeger:BaseManeger<Adres>,IAdresService
    {
        public AdresManeger(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
