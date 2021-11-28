using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Abstract
{
    public abstract class BaseProductManager : IProductService
    {
        public virtual void Add(Product product)
        {
            Console.WriteLine("Product {0} has been added to database.", product.Name);
        }

        public virtual void Delete(Product product)
        {
            Console.WriteLine("Product {0} is deleted from database.", product.Name);
        }

        public virtual void Update(Product product)
        {
            Console.WriteLine("Product {0} has been updated.", product.Name);
        }
    }
}
