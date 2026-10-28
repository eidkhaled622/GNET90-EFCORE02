using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET90_EFCORE02.Configuration
{
    public class EventEntityConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(e => e.Organizer)
            .WithMany(o => o.events)
            .HasForeignKey(e => e.OrganizerID);

            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.Desc).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Title).HasMaxLength(150).IsRequired();
            builder.Property(e => e.startDate).IsRequired();

            builder.HasKey(b => b.Id);
        }
    }
}