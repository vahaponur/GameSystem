using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Entity.Items
{
    public class Arm:Product
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int LevelToUse { get; set; }

    }
}
