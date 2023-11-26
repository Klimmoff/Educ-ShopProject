using Microsoft.EntityFrameworkCore;
using Products_Is42_2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Is42_2023.Data.Context
{
    class StoreContext : DbContext
    {
        public StoreContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB; Initial Catalog=productstore1; Integrated Security=True");
        }

        public DbSet<AttachedProduct> AttachedProduct { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientService> ClientService { get; set; }
        public DbSet<DocumentByService> DocumentByService { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductPhoto> ProductPhoto { get; set; }
        public DbSet<ProductSale> ProductSale { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ServicePhoto> ServicePhoto { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<TagOfClient> TagOfClient { get; set; }

    }
}
