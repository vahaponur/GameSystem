using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public virtual void Discount(float discountPercentage, Product product)
        {
            float discountReal = (product.Price / 100) * discountPercentage;
            product.Price -= discountReal;
        }

        public virtual void Discount(float discountPercentage, List<Product> products)
        {
            foreach (var product in products)
            {
                float discountReal = (product.Price / 100) * discountPercentage;
                product.Price -= discountReal;
            }
        }
    }
}
