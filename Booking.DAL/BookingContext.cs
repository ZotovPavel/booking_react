using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Booking.Common.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Booking.DAL
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();
            }

            modelBuilder.Entity<Country>().HasData(Data.SeedData.GetCountries());
            modelBuilder.Entity<City>().HasData(Data.SeedData.GetCities());
            modelBuilder.Entity<Raiting>().HasData(Data.SeedData.GetRaitings());
            modelBuilder.Entity<Hotel>().HasData(Data.SeedData.GetHotels());
            modelBuilder.Entity<Role>().HasData(Data.SeedData.GetRoles());
            modelBuilder.Entity<User>().HasData(Data.SeedData.GetUsers());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Raiting> Raiting { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
