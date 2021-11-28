using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Abstract
{
    public abstract class BaseSaleManager : ISaleService
    {
        public virtual void Sell(Product product, Customer customer)
        {
            customer.Inventory.Add(product);
            Console.WriteLine("{0} has been added to inventory.");
        }

        public virtual void Sell(List<Product> products, Customer customer)
        {
            foreach (var item in products)
            {
                customer.Inventory.Add(item);
            }
            Console.WriteLine("Items have been added to inventory.");
        }

    
    }
}
