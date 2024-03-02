using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercise>()
                .HasMany(e => e.Tracks)
                .WithMany(t => t.Exercises)
                .UsingEntity<Dictionary<string, object>>(
                    "ExerciseTrack",
                    j => j
                        .HasOne<Track>()
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Restrict), // Specify the cascade behavior you want here
                    j => j
                        .HasOne<Exercise>()
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Restrict) // Specify the cascade behavior you want here
                );


            modelBuilder.Entity<Exercise>()
                .HasOne(e => e.ExerciseType)
                .WithMany()
                .HasForeignKey(e => e.ExerciseTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>()
                .HasOne(c => c.CategoryType)
                .WithMany()
                .HasForeignKey(c => c.CategoryTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.EquipmentType)
                .WithMany()
                .HasForeignKey(e => e.EquipmentTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EnumValue>().HasData(
                new EnumValue { Id = 1, EnumType = "CategoryType", Name = "None" },
                new EnumValue { Id = 2, EnumType = "CategoryType", Name = "Beginner" },
                new EnumValue { Id = 3, EnumType = "CategoryType", Name = "Advanced" },
                new EnumValue { Id = 4, EnumType = "CategoryType", Name = "Expert" },
                new EnumValue { Id = 5, EnumType = "CategoryType", Name = "Champion" },
                new EnumValue { Id = 6, EnumType = "CategoryType", Name = "Open" },

                new EnumValue { Id = 7, EnumType = "ExerciseType", Name = "None" },

                new EnumValue { Id = 8, EnumType = "EquipmentType", Name = "None" }
            );
        }
    }
}