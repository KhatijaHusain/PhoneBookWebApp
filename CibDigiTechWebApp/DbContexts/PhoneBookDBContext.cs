using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CibDigiTechWebApp.Model;
using CibDigiTechWebApp.Dto;
using Microsoft.EntityFrameworkCore;

namespace CibDigiTechWebApp.DbContexts
{
    public class PhoneBookDBContext : DbContext
    {
        public DbSet<PhoneBookDto> PhoneBookDto { get; set; }
        public DbSet<EntryBookDto> EntryBook { get; set; }

        public PhoneBookDBContext(DbContextOptions<PhoneBookDBContext> options) : base(options)
        {
            AsReadOnly();
        }

        private PhoneBookDBContext AsReadOnly()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return this;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }
            modelBuilder.ApplyConfiguration(new PhoneBookConfiguration());
            modelBuilder.ApplyConfiguration(new EntryBookConfiguration());
        }
    }
}
