using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                Name = "Burak",
                LastName = "Filiz",
                BirthYear = "1996",
                NationalityId = "34234234234"
            };
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer);

            Game game = new Game()
            {
                Id = 1,
                GameName="CS GO",
                GamePrice=300
            };
            OrderManager orderManager = new OrderManager();
            orderManager.Buy(game,gamer);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign()
            {
                Id=1,
                CampaignName="Happy New Year",
                DiscountRate=30
            };

            campaignManager.Add(campaign, game);
        }
    }
}
