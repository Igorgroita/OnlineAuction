using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.API.Models;
using OnlineAuction.API.ModelsConfig;
using OnlineAuction.Domain.Auth;
using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API
{
    public class OnlineAuctionDbContext : IdentityDbContext<User, Role, long>
    {
        public OnlineAuctionDbContext(DbContextOptions<OnlineAuctionDbContext> options) : base(options) { }

        public DbSet<Lot> Lots { get; set; }
        public DbSet<Bet> Bets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Lot>().HasData(
            //        new Lot
            //        {
            //            Id = 1,
            //            LotName = "Napoleon's Hat",
            //            Description = "This is the hat that wore Napoleon the I of France....",
            //            MinimalBet = 1111121,
            //            Active = true,
            //            StartNegotiationTime = DateTime.Now
            //        }
            //    );



            base.OnModelCreating(modelBuilder);

            var assembly = typeof(LotConfig).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

        }

    }
}
