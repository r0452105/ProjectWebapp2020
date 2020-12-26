using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing0._1.Models;

namespace Testing0._1.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Ritsoort> Ritsoorten { get; set; }
        public DbSet<Rit> Ritten { get; set; }
        public DbSet<Uitslag> Uitslagen { get; set; }
        public DbSet<GebruikerTeam> GebruikersTeams { get; set; }
        public DbSet<RaceTeam> RacesTeams { get; set; }
        public DbSet<Nieuwsartikel> Nieuwsartikels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
            modelBuilder.Entity<Gebruiker>().Property(p => p.Naam).IsRequired();
            modelBuilder.Entity<Gebruiker>().Ignore(p => p.VolledigeNaam);

            modelBuilder.Entity<Team>().ToTable("Team");

            modelBuilder.Entity<Race>().ToTable("Race");

            modelBuilder.Entity<Ritsoort>().ToTable("Ritsoort");

            modelBuilder.Entity<Rit>().ToTable("Rit");

            modelBuilder.Entity<Uitslag>().ToTable("Uitslag");

            modelBuilder.Entity<GebruikerTeam>().ToTable("GebruikerTeam");

            modelBuilder.Entity<RaceTeam>().ToTable("RaceTeam");

            modelBuilder.Entity<Nieuwsartikel>().ToTable("Nieuwsartikel");




            //modelBuilder.Entity<Bestelling>().Property(p => p.Prijs).HasColumnType("decimal(18,2)");

        }
    }
}
