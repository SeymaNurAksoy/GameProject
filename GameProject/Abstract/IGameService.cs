using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
     public   interface IGameService
    {
        void GetAll(List<Games> games);

        void Sales(Customer customer,Games games,Campaign campaign);
    }
}
