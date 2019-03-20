using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Models
{
    public partial class CarDealershipContext : DbContext
    {
        public CarDealershipContext()
        {
        }

        public CarDealershipContext(DbContextOptions<CarDealershipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarDealership> CarDealership { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Engine> Engines { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Conection.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<CarDealership>(entity =>
            {
                entity.ToTable("Car_Dealership", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TownId).HasColumnName("town_id");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.CarDealership)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_town_id");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Cars", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarDealershipId).HasColumnName("car_dealership_id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EngineId).HasColumnName("engine_id");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.TransmissionGears).HasColumnName("transmission_gears");

                entity.Property(e => e.TransmissionType)
                    .IsRequired()
                    .HasColumnName("transmission_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CarDealership)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarDealershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cars_dealership");

                entity.HasOne(d => d.Engine)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.EngineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cars_engines");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("fk_cars_customers");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customers", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TownId).HasColumnName("town_id");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_customers_town_id");
            });

            modelBuilder.Entity<Engine>(entity =>
            {
                entity.ToTable("Engines", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Displacement).HasColumnName("displacement");

                entity.Property(e => e.EconomyPerHundredKm)
                    .HasColumnName("economy_per_hundred_km")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasColumnName("fuel_type")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Power).HasColumnName("power");
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.ToTable("Towns", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Workers", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarDealershipId).HasColumnName("car_dealership_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnName("position")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("money");

                entity.HasOne(d => d.CarDealership)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.CarDealershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_workers_dealership_id");
            });
        }
    }
}
