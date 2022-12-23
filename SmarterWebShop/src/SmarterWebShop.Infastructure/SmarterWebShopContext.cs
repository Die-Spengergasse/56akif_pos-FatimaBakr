using Bogus;
using Microsoft.EntityFrameworkCore;
using SmarterWebShop.Domain.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Infastructure
{
    public class SmarterWebShopContext : DbContext
    {
        public DbSet<Kunden> Kundens => Set<Kunden>();
        public DbSet<Preise> Preises => Set<Preise>();
        public DbSet<Produkte>Produktes => Set<Produkte>();
        public DbSet<Zeiten> Zeits => Set<Zeiten>();
        public DbSet<Rechnung> Rechnungss => Set<Rechnung>();

        public SmarterWebShopContext()
        {

        }
        public SmarterWebShopContext(DbContextOptions options) :base(options)
        { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlite("Data Source = Server =..........");
            //}
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Kunden>().HasKey(p => p.Id);
            //modelBuilder.Entity<Kunden>().Property(p => p.Id).IsRequired();
            //modelBuilder.Entity<Preise>().HasKey(p => p.Id);
            //modelBuilder.Entity<Preise>().Property(p => p.Id).IsRequired();
            //modelBuilder.Entity<Produkte>().HasKey(p => p.Id);
            //modelBuilder.Entity<Produkte>().Property(p => p.Id).IsRequired();
            //modelBuilder.Entity<Rechnung>().HasKey(p => p.ID);
            //modelBuilder.Entity<Rechnung>().Property(p => p.ID).IsRequired();
            //modelBuilder.Entity<Zeiten>().HasKey(p => p.Id);
            //modelBuilder.Entity<Zeiten>().Property(p => p.Id).IsRequired();



            // Value Object: ....
            modelBuilder.Entity<Kunden>().OwnsOne(k => k.Address);
        }

        public void Seed()
        {
            //List<Kunden> kunden = new Faker<Kunden>().CustomInstantiator(f =>
            //new Kunden(
            //    f.Random.Long(11111,9999),
            //    f.Name.FirstName(),
            //    f.Name.LastName(),
            //    f.Internet.Email())).Rules((f,k) =>
            //    {

            //        k.Address = new Address()
            //        {
            //            City = f.Address.City(),
            //            Number = f.Address.BuildingNumber(),
            //            Street = f.Address.StreetName(),
            //            Zip = f.Address.ZipCode(),
            //        };
            //        k.PhoneNumber = f.Phone.PhoneNumber();
            //    })
            //    .Generate(10)
            //    .ToList();
            //kunden.AddRange(kunden);
            //SaveChanges();

            List<Produkte> produktes = new Faker<Produkte>().CustomInstantiator(f =>
            new Produkte(
                f.Random.Long(11111, 9999),
                f.Commerce.ProductName()))
                .Generate(10)
                .ToList();
            produktes.AddRange(produktes);
            SaveChanges();
        }

    }
}
