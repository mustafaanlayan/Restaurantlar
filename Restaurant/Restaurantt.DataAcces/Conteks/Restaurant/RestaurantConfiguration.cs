using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantt.DataAcces.Conteks.Restaurant
{
   public class RestaurantConfiguration:DbMigrationsConfiguration<RestaurantContext>
    {
        public RestaurantConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
