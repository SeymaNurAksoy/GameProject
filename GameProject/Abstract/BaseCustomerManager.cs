using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public  abstract class BaseCustomerManager : ICustomerService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Delete to by : " + customer.FirstName);
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to by : " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Update to by : " + customer.FirstName);
        }
    }
}
