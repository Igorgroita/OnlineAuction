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

  
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var assembly = typeof(LotConfig).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            ApplyIdentityMapConfiguration(modelBuilder);
        }

        private void ApplyIdentityMapConfiguration(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Lot> Lots { get; set; }
        public DbSet<Bet> Bets { get; set; }




    }
}
