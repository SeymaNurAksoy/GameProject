using GameProject.Abstract;
using GameProject.Adaptor;
using GameProject.Concreate;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KAYIT EKLEME");
            Customer customer = new Customer();
            customer.FirstName = "Şeyma Nur";
            customer.LastName = "Aksoy";
            customer.NationalyId = 12752239584;
            customer.Birthday = 2000;

            Customer customer1 = new Customer();
            customer1.FirstName = "Şeyda Nur";
            customer1.LastName = "Yılmaz";
            customer1.NationalyId = 12252239584;
            customer1.Birthday = 2000;

            BaseCustomerManager manager= new CustomerManager((new MernisAdapter()));
            manager.Save(new Entities.Customer
            { Birthday = 2002, FirstName = "FAİK", LastName = "AKSOY", NationalyId = 21037963540, Id = 123 });

            BaseCustomerManager manager1 = new CustomerManager(new CustomerCheckManager());
            manager1.Save(customer);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("KAYIT SİLME");

            manager.Delete(customer);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("KAYIT GÜNCELLEME");

            manager.Update(customer1);


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("KAMPANYA LİSTESİ");
            Campaign campaign = new Campaign();
            campaign.CampaignName = "Öğrenci Kampanyası";
            campaign.CampaignId = 1;

            Campaign campaign1 = new Campaign();

            campaign1.CampaignName = "300 tl üzeri %30 indirim";
            campaign1.CampaignId = 2;

            List<Campaign> lists = new List<Campaign> { campaign,campaign1};


            BaseCampaignManager campaignManager = new CampaignManager ();
            campaignManager.GetAll(lists);


            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("KAMPANYA EKLE");

            BaseCampaignManager baseCampaignManager = new CampaignManager();
            lists.Add(new Campaign { CampaignId = 3, CampaignName = "500 TL üzeri %40 indirim" });
            baseCampaignManager.Save(lists, new Campaign { CampaignId = 3, CampaignName = "500 TL üzeri %40 indirim" });


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("KAMPANYA SİL");

            baseCampaignManager.Delete(campaign);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("KAMPANYA GÜNCELLE");

            baseCampaignManager.Update(campaign1);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("OYUN LİSTELEME ");

            Games games = new Games();
            games.GameName = "LOL";
            games.Price = 34;
            games.Id = 1;

            Games games1 = new Games();
            games1.GameName = "PUBG";
            games.Price = 120;
            games1.Id = 1;


            List<Games> liste = new List<Games> { games, games1 };


            BaseGameManager baseGameManager = new BaseGameManager();
            baseGameManager.GetAll(liste);


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("OYUN SATIŞ ");


            baseGameManager.Sales(customer, games1,campaign);



        }
    }
}
