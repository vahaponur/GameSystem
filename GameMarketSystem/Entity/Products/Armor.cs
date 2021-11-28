using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Entity.Items
{
    public class Armor : Product
    {
        public int DamageProtection { get; set; }
       
        public int LevelToUse { get; set; }

    }
}
