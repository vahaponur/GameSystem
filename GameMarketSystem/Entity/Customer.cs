using GameMarketSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Entity
{
    public sealed class Customer:Entity
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int DateYear { get; set; }
        public List<Product> Inventory { get; set; }

    }
}
