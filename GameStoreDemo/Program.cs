using System;
using System.Collections.Generic;

namespace GameStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Id = 1, Name = "Red Dead Redemption 2", Price = 300 };

            Game game2 = new Game() { Id = 2, Name = "The Long Dark", Price = 60 };

            Game game3 = new Game() { Id = 3, Name = "FIFA 2021", Price = 180 };

            // Datalar hayali olduğu için mernisten false döner.
            Gamer gamer1 = new Gamer()
            {
                Id = 10,
                BirthYear = 1999,
                FirstName = "Mustafa",
                LastName = "Öztürk",
                UserName = "mstfztrk",
                NationalityId = 11111111111,
                CreditCardNumber = 111111111
            };

            Gamer gamer2 = new Gamer()
            {
                Id = 20,
                BirthYear = 1999,
                FirstName = "Emine Merve ",
                LastName = "Ceylan",
                UserName = "eminemerveceylan",
                NationalityId = 22222222222,
                CreditCardNumber = 222222222
            };

            Gamer gamer3 = new Gamer()
            {
                Id = 30,
                BirthYear = 2015,
                FirstName = "Ayşe Sena",
                LastName = "öztürk",
                UserName = "aysesenaoztrk",
                NationalityId = 33333333333,
                CreditCardNumber = 33333333
            };

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 100,
                CampaignName = "Yaz İndirimleri",
                Discount = 25
            };

            Campaign campaign2 = new Campaign()
            {
                CampaignId = 200,
                CampaignName = "Yarı Yarıya",
                Discount = 50
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);


            CustomerManager customerManager = new GamerManager(new MernisServiceAdapter());
            customerManager.Save(gamer3);
            customerManager.Save(gamer1);
            customerManager.Save(gamer2);
            customerManager.Update(gamer2);


            Sales sales1 = new Sales() { Game = game1.Name, Gamer = gamer3.UserName };

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(game3, gamer3);
            salesManager.Buy(game1, gamer2);


        }
    }
}
