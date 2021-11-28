using GameMarketSystem.Abstract;
using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Concrete
{
    public class DatabaseValidator : ICustomerValidService
    {
        public bool CheckIfValid(Customer customer)
        {
            return !(String.IsNullOrEmpty(customer.FirstName) && string.IsNullOrEmpty(customer.LastName));
        }
    }
}
