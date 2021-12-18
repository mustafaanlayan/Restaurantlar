using Restaurant.Entites.Tables.Base;
using Restaurantt.DataAcces.Dals.Base;
using Restaurantt.DataAcces.Interface;
using System.Data.Entity;

namespace Restaurantt.DataAcces.Dals
{
    public class EkMalzemeDal : Repository<EkMalzeme>, IEkMalzemeDal
    {
        public EkMalzemeDal(DbContext context) : base(context)
        {
        }
    }
}
