using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API
{
    public class Seed
    {
        public static async Task SeedLots(OnlineAuctionDbContext context)
        {
            if (!context.Lots.Any())
            {
                var napoleonsHat = new Lot()
                {
                    LotName = "Napoleon's Hat",
                    Description = "This is the hat that wore Napoleon the I of France....",
                    MinimalBet = 1111121,
                    Active = true,
                    StartNegotiationTime = DateTime.Now
                };

                var jrrTolkinePipe = new Lot()
                {
                    LotName = "J.R.R. Tolkien's tobacco pipe",
                    Description = "This is the pipe that J.R.R. Tolkien used when he was alive ...",
                    MinimalBet = 123124141,
                    Active = true,
                    
                };
                var jamesBondsGun = new Lot()
                {
                    LotName = "James Bond's hand-gun",
                    Description = "This is the gun that the famous James Bond used for shooting at bad guys",
                    Active = true,
                    MinimalBet = 234234123
                };
                var messopotamianAncientMirror = new Lot()
                {
                    LotName = "Messopotamian Ancient Mirror",
                    Description = "This is a mirror used in ancient messopotamia by the kings"
                };

                context.Lots.Add(messopotamianAncientMirror);
                context.Lots.Add(jamesBondsGun);
                context.Lots.Add(jrrTolkinePipe);
                context.Lots.Add(napoleonsHat);
            }

            public static async 
        }

    }
}
