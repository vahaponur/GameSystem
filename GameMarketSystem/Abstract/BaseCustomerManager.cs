using GameMarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        ICustomerValidService _customerValidService;
        public BaseCustomerManager(ICustomerValidService customerValidService)
        {
            _customerValidService = customerValidService;
        }
        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Account is deleted.");
        }

        public virtual void Register(Customer customer)
        {
            if (_customerValidService.CheckIfValid(customer))
            {
                Console.WriteLine("Successfully registered.");
                return;
            }
            throw new Exception("User is not valid");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Information is updated.");
        }
    }
}
