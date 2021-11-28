using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Entity
{
    public class Product:Entity
    {
        public string Definition{ get; set; }
        public string Name{ get; set; }
        public float Price { get; set; }

    }
}
