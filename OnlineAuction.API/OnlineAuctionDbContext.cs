using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.API.Models;
using OnlineAuction.API.ModelsConfig;
using OnlineAuction.API.Auth;
using OnlineAuction.API.Models;
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
        public DbSet<Question> Questions { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Cathegory> Cathegories { get; set; }
        public DbSet<PhotoPath> PhotoPaths { get; set; }
        public DbSet<LotCathegory> LotCathegories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            var assembly = typeof(LotConfig).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            modelBuilder.Entity<LotCathegory>().HasKey(l => new { l.LotId, l.CathegoryId });

            modelBuilder.Entity<LotCathegory>()
                        .HasOne(lc => lc.Lot)
                        .WithMany(lc => lc.LotCathegories)
                        .HasForeignKey(lc => lc.LotId);

            modelBuilder.Entity<LotCathegory>()
                        .HasOne(lc => lc.Cathegory)
                        .WithMany(lc => lc.LotCathegories)
                        .HasForeignKey(lc => lc.CathegoryId);

            modelBuilder.Entity<PhotoPath>()
                        .HasOne(p => p.Lot)
                        .WithMany(l => l.PhotoPaths)
                        .HasForeignKey(p => p.LotId);

            modelBuilder.Entity<Question>()
                        .HasOne(q => q.Lot)
                        .WithMany(l => l.Questions)
                        .HasForeignKey(q => q.LotId);

        }

    }
}
