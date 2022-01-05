using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DQMA.Models;
using Microsoft.AspNetCore.Identity;

namespace DQMA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Attachments> Attachments { get; set; }
        public DbSet<Rejection> Rejections { get; set; }
        public DbSet<Parish> Parishes { get; set; }
        public DbSet<OffenseType> CrimeTypes { get; set; }
        public DbSet<OfficerRank> OfficerRanks { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Statement> Statements { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<OffenseType> OffenseTypes { get; set; }
        public DbSet<Motive> Motives { get; set; }
        public DbSet<Division> Divisions { get; set; }

        //Create default users
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string tempPassword = "123456";

            builder.Entity<IdentityRole>().HasData(new List<IdentityRole>
            { 
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Data Steward",
                    NormalizedName = "DATA STEWARD"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "Form Developer",
                    NormalizedName = "FORM DEVELOPER"
                }
            });

            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser {
                    Id = "1",
                    UserName = "admin@jcf.com",
                    NormalizedUserName = "ADMIN@JCF.COM",
                    PasswordHash = hasher.HashPassword(null, tempPassword)
                },
                new IdentityUser
                {
                    Id = "2",
                    UserName = "steward@jcf.com",
                    NormalizedUserName = "STEWARD@JCF.COM",
                    PasswordHash = hasher.HashPassword(null, tempPassword)
                },
                new IdentityUser
                {
                    Id = "3",
                    UserName = "developer@jcf.com",
                    NormalizedUserName = "DEVELOPER@JCF.COM",
                    PasswordHash = hasher.HashPassword(null, tempPassword)
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2"
                },
                new IdentityUserRole<string>
                { 
                    RoleId = "3",
                    UserId = "3"
                });

            builder.Entity<Division>().HasData(
                new Division
                {
                    Id = 1,
                    DivisionName = "Clarendon"
                },
                new Division
                {
                    Id = 2,
                    DivisionName = "Hanover"
                },
                new Division
                {
                    Id = 3,
                    DivisionName = "Kingston Central"
                },
                new Division
                {
                    Id = 4,
                    DivisionName = "Kingston Eastern"
                },
                new Division
                {
                    Id = 5,
                    DivisionName = "Kingston Western"
                },
                new Division
                {
                    Id = 6,
                    DivisionName = "Manchester"
                },
                new Division
                {
                    Id = 7,
                    DivisionName = "Portland"
                },
                new Division
                {
                    Id = 8,
                    DivisionName = "St. Andrew Central"
                },
                new Division
                {
                    Id = 9,
                    DivisionName = "St. Andrew North"
                },
                new Division
                {
                    Id = 10,
                    DivisionName = "St. Andrew South"
                },
                new Division
                {
                    Id = 11,
                    DivisionName = "St. Ann"
                },
                new Division
                {
                    Id = 12,
                    DivisionName = "St. Catherine North"
                },
                new Division
                {
                    Id = 13,
                    DivisionName = "St. Catherine South"
                },
                new Division
                {
                    Id = 14,
                    DivisionName = "St. Elizabeth"
                },
                new Division
                {
                    Id = 15,
                    DivisionName = "St. James"
                },
                new Division
                {
                    Id = 16,
                    DivisionName = "St. Mary"
                },
                new Division
                {
                    Id = 17,
                    DivisionName = "St. Thomas"
                },
                new Division
                {
                    Id = 18,
                    DivisionName = "Trelawny"
                },
                new Division
                {
                    Id = 19,
                    DivisionName = "Westmoreland"
                }
                );
        }
    }
}