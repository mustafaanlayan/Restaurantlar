using Restaurant.Entites.Tables;
using Restaurantt.DataAcces.Dals.Base;
using Restaurantt.DataAcces.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantt.DataAcces.Dals
{
   public class UrunDal:Repository<Urun>,IUrunDal
    {
        public UrunDal(DbContext context) : base(context)
        {

        }
    }
}
