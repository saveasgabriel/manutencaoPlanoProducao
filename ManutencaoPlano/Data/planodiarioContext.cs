using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ManutencaoPlano.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ManutencaoPlano.Data
{
    public partial class planodiarioContext : DbContext
    {

        public planodiarioContext(DbContextOptions<planodiarioContext> options) : base(options)
        {
        }

        public DbSet<FtAbateQuarteioHabilitacao> FtAbateQuarteioHabilitacao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FtAbateQuarteioHabilitacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ft_abate_quarteio_habilitacao", "fato");

                entity.Property(e => e.Cbd)
                    .HasColumnName("cbd")
                    .HasMaxLength(50);

                entity.Property(e => e.Ccdbarra)
                    .HasColumnName("ccdbarra")
                    .HasMaxLength(50);

                entity.Property(e => e.Cquarto)
                    .HasColumnName("cquarto")
                    .HasMaxLength(50);

                entity.Property(e => e.Csexo)
                    .HasColumnName("csexo")
                    .HasMaxLength(50);

                entity.Property(e => e.Dentradaestoque)
                    .HasColumnName("dentradaestoque")
                    .HasColumnType("date");

                entity.Property(e => e.Dmovimento)
                    .HasColumnName("dmovimento")
                    .HasColumnType("date");

                entity.Property(e => e.Dsaidaestoque)
                    .HasColumnName("dsaidaestoque")
                    .HasColumnType("date");

                entity.Property(e => e.Dvalidade)
                    .HasColumnName("dvalidade")
                    .HasColumnType("date");

                entity.Property(e => e.Ibanda).HasColumnName("ibanda");

                entity.Property(e => e.Iidade).HasColumnName("iidade");

                entity.Property(e => e.Isequencial).HasColumnName("isequencial");

                entity.Property(e => e.Ncdcaracteristica).HasColumnName("ncdcaracteristica");

                entity.Property(e => e.Ncdempresaabate).HasColumnName("ncdempresaabate");

                entity.Property(e => e.Ncdempresaproducao).HasColumnName("ncdempresaproducao");

                entity.Property(e => e.Ncdhabilitacaocalhasangria).HasColumnName("ncdhabilitacaocalhasangria");

                entity.Property(e => e.Ncdhabilitacaocamara).HasColumnName("ncdhabilitacaocamara");

                entity.Property(e => e.Ncdhabilitacaocompragado).HasColumnName("ncdhabilitacaocompragado");

                entity.Property(e => e.Ncdhabilitacaoescala).HasColumnName("ncdhabilitacaoescala");

                entity.Property(e => e.Ncdhabilitacaoordemproducao).HasColumnName("ncdhabilitacaoordemproducao");

                entity.Property(e => e.Ncdhabilitacaorecebimento).HasColumnName("ncdhabilitacaorecebimento");

                entity.Property(e => e.Ncdhabilitacaotipificacao).HasColumnName("ncdhabilitacaotipificacao");

                entity.Property(e => e.Ncdhabilitacaotransferencia).HasColumnName("ncdhabilitacaotransferencia");

                entity.Property(e => e.Ncdhistoricoentrada).HasColumnName("ncdhistoricoentrada");

                entity.Property(e => e.Ncdhistoricosaida).HasColumnName("ncdhistoricosaida");

                entity.Property(e => e.Ncdordemproducao).HasColumnName("ncdordemproducao");

                entity.Property(e => e.Ncdproduto).HasColumnName("ncdproduto");

                entity.Property(e => e.Ncdtipoproducao).HasColumnName("ncdtipoproducao");

                entity.Property(e => e.Npeso).HasColumnName("npeso");

                entity.Property(e => e.Npesobruto).HasColumnName("npesobruto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
