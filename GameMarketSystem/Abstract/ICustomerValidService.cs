using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Abstract
{
    public interface ICustomerValidService
    {
        bool CheckIfValid(Customer customer);
    }
}
