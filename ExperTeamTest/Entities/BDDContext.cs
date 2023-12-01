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
            //TABLA GUIA
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


            //TABLA FACTURA
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => new { e.IdFactura });

                entity.ToTable("Factura", "dbo");

                entity.Property(e => e.Establecimiento)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PuntoEmision)
                  .IsRequired()
                  .HasMaxLength(3)
                  .IsUnicode(false);

                entity.Property(e => e.Secuencial)
                  .IsRequired()
                  .HasMaxLength(3)
                  .IsUnicode(false);

                entity.Property(e => e.FechaEmision)
                  .IsRequired();

                entity.Property(e => e.Subtotal)
                .IsRequired();

                entity.Property(e => e.Impuesto)
                .IsRequired();

                entity.Property(e => e.Total)
                    .IsRequired();

               

            });


            //TABLA GUIA- FACTURA
            modelBuilder.Entity<Guide_Invoice>(entity =>
            {
                entity.HasKey(e => new { e.IdFactura, e.IdGuia });

                entity.ToTable("Guia_Factura", "dbo");

                entity.Property(e => e.IdFactura)
                .IsRequired();

                entity.Property(e => e.IdGuia)
               .IsRequired();

                entity.Property(e => e.DateCreate)
                .IsRequired();

                entity.Property(e => e.UserCreate)
                .IsRequired();


            });

            //TABLA PAGO
            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => new { e.IdPago });

                entity.ToTable("Pago", "dbo");

                entity.Property(e => e.tipoPago)
                   .IsRequired()
                   .HasMaxLength(100)
                   .IsUnicode(false);

                entity.Property(e => e.valor)
                .IsRequired();


            });


            //TABLA FACTURA-PAGO
            modelBuilder.Entity<Pago_Factura>(entity =>
            {
                entity.HasKey(e => new { e.IdPago, e.IdFactura }); ;

                entity.ToTable("Factura_Pago", "dbo");

                entity.Property(e => e.DateCreate)
                .IsRequired();


            });
        }
    }
}

//Agrega el paque nuget de SQL server

