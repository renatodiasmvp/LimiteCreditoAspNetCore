using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace LimiteCreditoAspNetCore.Models
{
    public class ContextoDeDados : DbContext
    {
        public ContextoDeDados(DbContextOptions<ContextoDeDados> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=CREDITODB;User Id=sa;Password=zaxx34");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .HasKey(l => l.IDE_LIMITE_CREDITO);

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.DAT_EXPIRA_LIMITE)
                .HasColumnType("datetime");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.DES_OBSERVACAO)
                .HasColumnType("nvarchar(255)");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.VLR_TOTAL_APROVACAO)
                .HasColumnType("money");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.PER_TAXA_OPERACAO)
                .HasColumnType("numeric");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.VLR_TARIFA_OPERACAO)
                .HasColumnType("money");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.VLR_TOTAL_DESCONTOS)
                .HasColumnType("money");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.VLR_LIQUIDO_APROVACAO)
                .HasColumnType("money");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.LIS_SITUACAO)
                .HasColumnType("nvarchar(20)");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.NOM_LOGIN_APROVACAO)
                .HasColumnType("nvarchar(255)");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.DAT_APROVACAO)
                .HasColumnType("datetime");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.DES_APROVACAO)
                .HasColumnType("nvarchar(255)");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.STS_LIMITE)
                .HasColumnType("nvarchar(1)");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.DAT_INCLUSAO)
                .HasColumnType("datetime");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.NOM_LOGIN_INCLUSAO)
                .HasColumnType("nvarchar(255)");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.NUM_IP_INCLUSAO)
                .HasColumnType("nvarchar(50)");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.DAT_ALTERACAO)
                .HasColumnType("datetime");

            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .Property(l => l.NOM_LOGIN_ALTERACAO)
                .HasColumnType("nvarchar(255)");


            modelBuilder.Entity<LIMITES_CREDITO_LIC>()
                .ToTable("LIMITES_CREDITOS_LIC");


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<LIMITES_CREDITO_LIC> lIMITES_CREDITO_LIC { get; set; }
    }
}
