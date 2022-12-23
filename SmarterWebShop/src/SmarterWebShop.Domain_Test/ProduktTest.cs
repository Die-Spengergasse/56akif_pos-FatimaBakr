using Microsoft.EntityFrameworkCore;
using SmarterWebShop.Domain.Modell;
using SmarterWebShop.Infastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain_Test
{
    public class ProduktTest
    {
        private SmarterWebShopContext GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source = SmarterWebShop_Test.db");

            SmarterWebShopContext db = new SmarterWebShopContext(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        [Fact]
        public void SeedDb()
        {
            SmarterWebShopContext db=GenerateDb();
            db.Seed();
            Assert.True(true);
        }

        [Fact]
        public void Product_Add_One_Entity_SuccessTest()
        {
            SmarterWebShopContext db = GenerateDb();
            Produkte newProdukt = new Produkte(1,"Baklawa");
            db.Produktes.Add(newProdukt);
            db.SaveChanges();
            Assert.Equal(1, db.Produktes.Count());
        }
    }
}
