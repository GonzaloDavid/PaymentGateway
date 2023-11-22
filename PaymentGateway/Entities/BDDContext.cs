using System;
using Microsoft.EntityFrameworkCore;
using PaymentGateway.Modelos;

namespace PaymentGateway.Entities
{
	public class BDDContext : DbContext
    {

        public DbSet<TransactionModel> TTransaction { get; set; }

        public BDDContext(DbContextOptions<BDDContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server=localhost;
            //Data Source=localhost;
            optionsBuilder.UseSqlServer(
               @"Server=localhost;Initial Catalog=PaymentGateway; Database=PaymentGateway;Trusted_Connection=false ; User Id=sa;Password=MiPassw0rd!1521; TrustServerCertificate=true;");
        }

        //Aqui se configura temas adicionales para los modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TransactionModel>(entity =>
            {
                entity.HasKey(e => new { e.IdTransaction });

                entity.Property(e => e.ValuePurchase)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePurchase)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired();

                entity.Property(e => e.UserLastModify)
                    .IsRequired();

                entity.Property(e => e.DateCreate)
                    .IsRequired();

                entity.Property(e => e.DateLastModify)
                    .IsRequired();
            });
        }
    }
}

