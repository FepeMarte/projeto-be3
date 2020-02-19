using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CadastroDePacientesBe3.Models
{
    public partial class DB5566Context : DbContext
    {
        public DB5566Context()
        {
        }

        public DB5566Context(DbContextOptions<DB5566Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Convenios> Convenios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=db_sql.be3.co,1515;Database=DB5566;User ID=felipe.duarte;Password=ProcSeletivo#2020");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Prontuario);

                entity.Property(e => e.Celular).HasMaxLength(20);

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(14);

                entity.Property(e => e.DtNasc)
                    .HasColumnName("Dt_Nasc")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FoneRes)
                    .HasColumnName("Fone_Res")
                    .HasMaxLength(20);

                entity.Property(e => e.IdConvenio).HasColumnName("ID_Convenio");

                entity.Property(e => e.NCarteirinha)
                    .HasColumnName("N_Carteirinha")
                    .HasMaxLength(20);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.NomeMae)
                    .HasColumnName("Nome_Mae")
                    .HasMaxLength(50);

                entity.Property(e => e.Rg)
                    .HasColumnName("RG")
                    .HasMaxLength(15);

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UF)
                    .HasColumnName("UF")
                    .HasMaxLength(15);

                entity.Property(e => e.DtValidade)
                 .HasColumnName("Dt_Validade")
                 .HasMaxLength(15);
            });

            modelBuilder.Entity<Convenios>(entity =>
            {
                entity.HasKey(e => e.IdConvenio);

                entity.Property(e => e.IdConvenio).HasColumnName("ID_Convenio");

                entity.Property(e => e.Empresa).HasMaxLength(50);
            });
        }
    }
}
