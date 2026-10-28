using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE02.Configuration;
using GNET90_EFCORE02.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GNET90_EFCORE02.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>()
                .ComplexProperty(o => o.Address); // Composite Column

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BadgeConfiguration).Assembly);
        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<organizerProfile> organizerProfiles { get; set; }
        public DbSet<Attendee> Attenders { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Badge> Badges { get; set; }
    }
}