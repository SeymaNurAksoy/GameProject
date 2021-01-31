using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
  public  class Customer
    {
        public int Id { get; set; }

        public long NationalyId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Birthday { get; set; }
    }
}
