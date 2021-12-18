using Restaurant.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entites.Tables.Base
{
   public  class Tanim:EntityBase
    {
        public string Adi { get; set; }

        public TanimTip TanimTip { get; set; }
    }
}
