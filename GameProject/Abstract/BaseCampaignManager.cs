using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "silindi");
        }

        public void GetAll(List<Campaign> campaigns)
        {
            Console.WriteLine("KAMPANYALAR ");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }
        }
        

        public void Save(List<Campaign> campaigns,Campaign  addCampaigns)
        {
            Console.WriteLine("Eklendi : " + addCampaigns.CampaignName);
            Console.WriteLine("---------------------------------------------" );

            Console.WriteLine(" KAMPANYALAR ");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }

        }

        public void Update(Campaign campaign)
        {

            Console.WriteLine(campaign.CampaignName + "güncellendi");
        }

        internal void Save(object v)
        {
            throw new NotImplementedException();
        }
    }
}
