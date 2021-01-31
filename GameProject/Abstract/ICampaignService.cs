using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Save(List<Campaign> campaign,Campaign campaign1);

        void Update(Campaign campaign);

        void Delete(Campaign campaign);

        void GetAll(List<Campaign> campaigns);
    }
}
