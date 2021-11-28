using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Abstract
{
    public interface ICampaignService
    {
        void Discount(float discountPercentage, Product product);
        void Discount(float discountPercentage, List<Product> products);
       
    }
}
