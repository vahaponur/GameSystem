using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Abstract
{
    public interface ISaleService
    {
        void Sell(Product product, Customer customer);
        void Sell(List<Product> products, Customer customer);
        
    }
}
