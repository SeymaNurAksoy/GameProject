using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concreate
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPersonel(Customer customer)
        {
            return true;
        }
    }


}
