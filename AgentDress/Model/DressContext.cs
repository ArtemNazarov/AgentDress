using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentDressReborn.Model
{
    public class DressContext : DbContext
    {


        public virtual DbSet<Dress> Dresses { get; set; }

        public virtual DbSet<Color> Colors { get; set; }

        public virtual DbSet<Size> Sizes { get; set; }

        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<DressType> DressTypes { get; set; }

        public virtual DbSet<DressCollection> DressCollections { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public DressContext(DbContextOptions<DressContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AgentDress;Trusted_Connection=True;");
            if (!optionsBuilder.IsConfigured)
            {
                throw new Exception("В DressContext отсутствует строка подключения.");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<DressCollection>().HasMany(e => e.Dresses);

            modelBuilder.Entity<Dress>()
            .HasMany(e => e.Sizes);

            modelBuilder.Entity<Dress>()
            .HasMany(e => e.Colors);

            modelBuilder.Entity<Dress>()
            .HasMany(e => e.DressCollections);

            modelBuilder.Entity<Dress>()
.HasMany(e => e.Stores);

            modelBuilder.Entity<Store>().HasMany(e => e.Dresses);
            modelBuilder.Entity<Color>();
            modelBuilder.Entity<Size>();
            modelBuilder.Entity<DressType>();
            modelBuilder.Entity<Category>();
            modelBuilder.Entity<Manufacturer>();

        }

    }
}
