
using System;
using System.Collections.Generic;
using System.Text;
using TimeTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TimeTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            /*           modelBuilder.Entity<Order>()
                           .Property(b => b.DateCreated)
                           .HasDefaultValueSql("GETDATE()");
           */
            // Restrict deletion of related user when UserCategories entry is removed
            modelBuilder.Entity<User>()
                .HasMany(uc => uc.UserCategories)
                .WithOne(l => l.User)
                .OnDelete(DeleteBehavior.Restrict);

            /*            modelBuilder.Entity<User>()
                            .Property(b => b.DateCreated)
                            .HasDefaultValueSql("GETDATE()");  */

            // Restrict deletion of related category when UserCategories entry is removed
            modelBuilder.Entity<Category>()
                .HasMany(uc => uc.UserCategories)
                .WithOne(l => l.Category)
                .OnDelete(DeleteBehavior.Restrict);



            User user = new User
            {
                UserName = "danielbrewer15@gmail.com",
                NormalizedUserName = "DANIELBREWER15@GMAIL.COM",
                Email = "danielbrewer15@gmail.com",
                NormalizedEmail = "DANIELBREWER15@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };


           


            var passwordHash = new PasswordHasher<User>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<User>().HasData(user);



            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    UserId = user.Id,
                    Title = "Exercise"
                },
                new Category()
                {
                    Id = 2,
                    UserId = user.Id,
                    Title = "Study"
                },

                new Category()
                {
                    Id = 3,
                    UserId = user.Id,
                    Title = "Entertainment"
                },

                 new Category()
                 {
                     Id = 4,
                     UserId = user.Id,
                     Title = "Guitar Practice"
                 },

                  new Category()
                  {
                      Id = 5,
                      UserId = user.Id,
                      Title = "Reading"
                  }

            );

            modelBuilder.Entity<UserCategory>().HasData(
                new UserCategory()
                {
                    Id = 1,
                    UserId = user.Id,
                    CategoryId = 1
                }
            );

            modelBuilder.Entity<UserCategory>().HasData(
                new UserCategory()
                {
                    Id = 2,
                    UserId = user.Id,
                    CategoryId = 2
                }
             );
            modelBuilder.Entity<UserCategory>().HasData(
                new UserCategory()
                {
                    Id = 3,
                    UserId = user.Id,
                    CategoryId = 3
                }
            );
            modelBuilder.Entity<UserCategory>().HasData(
                new UserCategory()
                {
                    Id = 4,
                    UserId = user.Id,
                    CategoryId = 4
                }
            );
        }
    }
}