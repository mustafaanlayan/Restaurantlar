using Restaurant.Entites.Tables.Base;
using Restaurantt.DataAcces.Dals.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantt.DataAcces.Dals
{
    public class PorsiyonDal : Repository<Porsiyon>, IPorsiyon
    {
        public PorsiyonDal(DbContext context) : base(context)
        {
        }
    }
}
