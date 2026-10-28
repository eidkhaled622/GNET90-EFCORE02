using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client.RP;
using Models;

namespace GNET90_EFCORE02.Configuration
{
    public class profileConfiguration : IEntityTypeConfiguration<organizerProfile>
    {
        public void Configure(EntityTypeBuilder<organizerProfile> builder)
        {
            builder.HasOne(p => p.organizer)
            .WithOne(o => o.Profile)
            .HasForeignKey<organizerProfile>(p => p.OrganizerID);

            builder.Property(p => p.Bio).IsRequired();
            builder.Property(p => p.Link).IsRequired();

            builder.HasKey(b => b.id);
        }
    }
}