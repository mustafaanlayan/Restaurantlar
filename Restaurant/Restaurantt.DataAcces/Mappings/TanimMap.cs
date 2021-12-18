using Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantt.DataAcces.Mappings
{
   public class TanimMap:EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            Property(c => c.Adi).HasMaxLength(50);

            ToTable("Tanimler");

            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.TanimTip).HasColumnName("TanimTipi");
        }
    }
}
