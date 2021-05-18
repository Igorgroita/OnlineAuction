using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.ModelsConfig
{
    public class LotConfig : IEntityTypeConfiguration<Lot>
    {
        public void Configure(EntityTypeBuilder<Lot> builder)
        {
            builder.Property(x => x.LotName)
                    .IsRequired()
                    .HasMaxLength(200);

            builder.Property(x => x.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

            builder.Property(x => x.AuctioneerId)
                    .IsRequired();
            builder.Property(x => x.StartNegotiationTime)
                    .IsRequired();
        }
    }
}
