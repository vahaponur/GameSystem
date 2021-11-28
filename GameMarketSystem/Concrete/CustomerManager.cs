using GameMarketSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Concrete
{
    public class CustomerManager : BaseCustomerManager
    {
        public CustomerManager(ICustomerValidService customerValidService):base(customerValidService)
        {
            
        }
    }
}
