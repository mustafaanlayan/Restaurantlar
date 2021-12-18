using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Entites.Tables;
using Restaurantt.DataAcces.Dals.Base;
using Restaurantt.DataAcces.Interface;

namespace Restaurantt.DataAcces.Dals
{
   public class AdresDal:Repository<Adres>,IAdresDal
    {
        public AdresDal(DbContext context) : base(context)
        {
        }
    }
}
