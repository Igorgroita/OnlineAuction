using Microsoft.EntityFrameworkCore;
using OnlineAuction.API.ModelsConfig;
using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API
{
    public class OnlineAuctionDbContext: DbContext
    {
        public OnlineAuctionDbContext(DbContextOptions<OnlineAuctionDbContext> options) : base(options) { }

        public DbSet<Lot> Lots { get; set; }

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
    }
}
