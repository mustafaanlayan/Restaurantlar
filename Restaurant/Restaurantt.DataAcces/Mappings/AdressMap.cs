using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Entites.Tables;

namespace Restaurantt.DataAcces.Mappings
{
   public class AdressMap:EntityTypeConfiguration<Adres>
    {
        public AdressMap()
        {
            Property(c => c.Il).HasMaxLength(30);
            Property(c => c.Ilce).HasMaxLength(30);
            Property(c => c.Adresi).HasMaxLength(100);
            Property(c => c.Semt).HasMaxLength(300);

            ToTable("Adresler");
            Property(c => c.Il).HasColumnName("Il");
            Property(c => c.Ilce).HasColumnName("Ilce");
            Property(c => c.Adresi).HasColumnName("Adresi");
            Property(c => c.Semt).HasColumnName("Semt");
            Property(c => c.TelefonAdresTip).HasColumnName("TelefonAdresTip");

        }
    }
}
