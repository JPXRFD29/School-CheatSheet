using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Runtime.ConstrainedExecution;
using Template.Data.Models;
using Microsoft.UI.Xaml.Media;

namespace Template.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<MovieAiring> MovieAirings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                ConfigurationManager.ConnectionStrings["TemplateDataBase"].ConnectionString,
                ServerVersion.Parse("10.4.17-mariadb")
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .OwnsOne(u => u.Address);

            modelBuilder.Entity<Theater>()
                .OwnsOne(t => t.Address);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    UserName = "Admin",
                    Email = "admin@companyname.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("admin123"),
                    Credit = -1.0m,  // $-1.0 => inf.
                    Role = Role.Admin
                },
                new User
                {
                    Id = 2,
                    Name = "Narek",
                    UserName = "CaptainDoubleDicks911",
                    Email = "CaptainDoubleDicks911@shemail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Narek29071884"),
                    Credit = 1000000000.00m,
                    Role = Role.Client
                },
                new User
                {
                    Id = 3,
                    Name = "Marsoul",
                    UserName = "Marius",
                    Email = "marsoul@companyname.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("marsoul123"),
                    Credit = 0.00m,
                    Role = Role.Manager,
                    TheaterId = 1
                },
                new User
                {
                    Id = 4,
                    Name = "Marouan",
                    UserName = "Ryzlar",
                    Email = "marouan@companyname.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("marouan123"),
                    Credit = 0.00m,
                    Role = Role.Worker,
                    TheaterId = 2
                },
                new User
                {
                    Id = 5,
                    Name = "Ryan",
                    UserName = "Skaffaboys",
                    Email = "ryan@companyname.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("marouan123"),
                    Credit = 0.00m,
                    Role = Role.Client
                }
            );
            modelBuilder.Entity<User>()
                .OwnsOne(u => u.Address)
                .HasData(
                new
                {
                    UserId = 1,
                    Street = "Unknown",
                    City = "Unknown",
                    PostalCode = "Unknown",
                    Country = "Unknown"
                },
                new
                {
                    UserId = 2,
                    Street = "Więźniów Oświęcimia 55",
                    City = "Oświęcim",
                    PostalCode = "32-600",
                    Country = "Poland"
                },
                new
                {
                    UserId = 3,
                    Street = "Więźniów Oświęcimia 56",
                    City = "Oświęcim",
                    PostalCode = "32-600",
                    Country = "Poland"
                },
                new 
                { 
                    UserId = 4,
                    Street = "Dharmapuri, Forest Colony, Tajganj", 
                    City = "Agra (Uttar Pradesh)", 
                    PostalCode = "282001", 
                    Country = "India" 
                },
                new
                {
                    UserId = 5,
                    Street = "Willeminastraat 15",
                    City = "Gotham City (aka. Steenbergen)",
                    PostalCode = "4755 AP",
                    Country = "Netherlands"
                }
            );

            modelBuilder.Entity<Theater>(b =>
            {
                b.HasData(
                    new Theater
                    {
                        Id = 1,
                        Name = "Pathé Breda",
                    },
                    new Theater
                    {
                        Id = 2,
                        Name = "C-Cinema Roosendaal",
                    }
                );
            });
            modelBuilder.Entity<Theater>()
                .OwnsOne(t => t.Address)
                .HasData(
                new
                {
                    TheaterId = 1,
                    Street = "Chasséveld 15",
                    City = "Breda",
                    PostalCode = "4811 DH",
                    Country = "Netherlands"
                },
                new
                {
                    TheaterId = 2,
                    Street = "Nieuwstraat 2",
                    City = "Roosendaal",
                    PostalCode = "4701 HS",
                    Country = "Netherlands"
                }
            );

            modelBuilder.Entity<Movie>(b =>
            {
                b.HasData(new Movie
                {
                    Id = 1,
                    Name = "The Super Mario Galaxy Movie",
                    Description = @"Mario ventures into space, exploring cosmic worlds and tackling galactic challenges far from the familiar Mushroom Kingdom.",
                    Duration = new TimeOnly(1, 38),
                    PosterUrl = "",
                    Rating = 3.3f
                },
                new Movie
                {
                    Id = 2,
                    Name = "Project Hail Mary",
                    Description = @"A science teacher wakes up alone on a spaceship. As his memory returns, he uncovers a mission to stop a mysterious substance killing Earth's sun and that an unexpected friendship may be the key.",
                    Duration = new TimeOnly(2, 36),
                    PosterUrl = "",
                    Rating = 4.2f
                },
                new Movie
                {
                    Id = 3,
                    Name = "Dune: Part Two",
                    Description = @"Paul Atreides unites with the Fremen while on a warpath of revenge against the conspirators who destroyed his family. Facing a choice between the love of his life and the fate of the universe, he endeavors to prevent a terrible future.",
                    Duration = new TimeOnly(2, 46),
                    PosterUrl = "",
                    Rating = 4.2f
                });
            });

            modelBuilder.Entity<MovieAiring>().HasData(
                new MovieAiring
                {
                    Id = 1,
                    TheaterId = 1,
                    MovieId = 1,
                    Airing = new DateTime(2026, 04, 07, 20, 00, 00)
                },
                new MovieAiring
                {
                    Id = 2,
                    TheaterId = 1,
                    MovieId = 3,
                    Airing = new DateTime(2026, 04, 07, 22, 00, 00)
                }
            );
        }
    }
}