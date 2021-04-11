using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikMVC.Models
{
    public class DziennikDbContext:IdentityDbContext<Konto>
    {
        public DziennikDbContext(DbContextOptions<DziennikDbContext> options)
       : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Wiadomosc>(entity =>
            //{
            //    entity.HasOne(x => x.Nadawca)
            //    .WithMany(x => x.Wiadomosci_wyslane)
            //    .HasForeignKey(x => x.NadawcaId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //    entity.HasOne(x => x.Odbiorca)
            //    .WithMany(x => x.Wiadomosci_odebrane)
            //    .HasForeignKey(x => x.OdbiorcaId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //});
            builder.Entity<Konto>(entity =>
            {
                entity.HasMany(x => x.Wiadomosci_odebrane)
                .WithOne(x => x.Odbiorca)
                .HasForeignKey(x => x.OdbiorcaId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasMany(x => x.Wiadomosci_wyslane)
                .WithOne(x => x.Nadawca)
                .HasForeignKey(x => x.NadawcaId)
                .OnDelete(DeleteBehavior.NoAction);
            });
        }
        public DbSet<Klasa> Klasa { get; set; }
        public DbSet<Konto> Konto { get; set; }
        public DbSet<Lekcja> Lekcja { get; set; }
        public DbSet<Nauczanie> Nauczanie { get; set; }
        public DbSet<Nauczyciel> Nauczyciel { get; set; }
        public DbSet<Obecnosc> Obecnosc { get; set; }
        public DbSet<Ocena> Ocena { get; set; }
        public DbSet<Przedmiot> Przedmiot { get; set; }
        public DbSet<Uczen> Uczen { get; set; }
        public DbSet<Wiadomosc> Wiadomosc { get; set; }
        public DbSet<Wydarzenie> Wydarzenie { get; set; }
    }
}
