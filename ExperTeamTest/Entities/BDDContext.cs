using System;
using Microsoft.EntityFrameworkCore;

namespace ExperTeamTest.Entities
{
	public class BDDContext : DbContext
    {
        public DbSet<Guide> Guide { get; set; }

        public BDDContext(DbContextOptions<BDDContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server=localhost;Initial Catalog=ExperTeam; Database=ExperTeam;Trusted_Connection=false ; User Id=sa;Password=MiPassw0rd!1521; TrustServerCertificate=true;");
        }

        //Aqui se configura temas adicionales para los modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Guide>(entity =>
            {
                entity.HasKey(e => new { e.IdGuia });

                entity.ToTable("Guia", "dbo");

                entity.Property(e => e.NumeroGuia)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEnvio)
                    .IsRequired();

                entity.Property(e => e.PaisOrigen)
                     .IsRequired()
                     .HasMaxLength(100)
                     .IsUnicode(false);

                entity.Property(e => e.NombreRemitente)
                   .IsRequired()
                   .HasMaxLength(100)
                   .IsUnicode(false);

                entity.Property(e => e.PaisDestino)
                  .IsRequired()
                  .HasMaxLength(100)
                  .IsUnicode(false);

                entity.Property(e => e.NombreDestinatario)
                 .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(false);

                entity.Property(e => e.DireccionDestinatario)
                  .IsRequired()
                  .HasMaxLength(100)
                  .IsUnicode(false);

            });
        }
    }
}

//Agrega el paque nuget de SQL server

