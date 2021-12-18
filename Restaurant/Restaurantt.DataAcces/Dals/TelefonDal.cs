using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Entites.Tables.Base;
using Restaurantt.DataAcces.Dals.Base;
using Restaurantt.DataAcces.Interface;

namespace Restaurantt.DataAcces.Dals
{
   public class TelefonDal:Repository<Telefon>,ITelefonDal
    {
        public TelefonDal(DbContext context) : base(context)
        {
        }
    }
}
