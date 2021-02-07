using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası eklendi ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası kaldırıldı");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi");
        }
    }
}
