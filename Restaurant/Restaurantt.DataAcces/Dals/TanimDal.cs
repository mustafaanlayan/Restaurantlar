using Restaurant.Entites.Tables.Base;
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
    public class TanimDal : Repository<Tanim>, ITanimDal
    {
        public TanimDal(DbContext context) : base(context)
        {
        }
    }
}
