using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public class BaseGameManager : IGameService
    {
        public void GetAll(List<Games> games)
        {
            Console.WriteLine("Oyunlar  ve Fiyatları  ");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName +" Fiyatı : "+ game.Price);
            }
        }

        public void Sales(Customer customer,Games games,Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + "  " + games.GameName + " isimli oyunu "+campaign.CampaignName +"  kampanyasıyla almıştır.");
        }
    }
}
