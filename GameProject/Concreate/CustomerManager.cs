using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
   public class CustomerManager:BaseCustomerManager
    {
        ICustomerCheckService checkService;

        public CustomerManager(ICustomerCheckService checkService)
        {
            this.checkService = checkService;
        }
        public override void Save(Customer customer)
        {
            if (checkService.CheckIfRealPersonel(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Kayıt olamadı.");
            }
        }
    }
}
