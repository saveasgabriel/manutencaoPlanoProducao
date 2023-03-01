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

        public DbSet<ViewDisponibilidadeQuartos> ViewDisponibilidadeQuartos { get; set; }


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

            modelBuilder.Entity<ViewDisponibilidadeQuartos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("view_disponibilidade_quartos", "fato");

                entity.Property(e => e.Alb)
                    .HasColumnName("alb")
                    .HasMaxLength(50);

                entity.Property(e => e.Arg)
                    .HasColumnName("arg")
                    .HasMaxLength(50);

                entity.Property(e => e.Ccamaradeestocagem)
                    .HasColumnName("ccamaradeestocagem")
                    .HasMaxLength(50);

                entity.Property(e => e.Ccb)
                    .HasColumnName("ccb")
                    .HasMaxLength(50);

                entity.Property(e => e.Cgrdura)
                    .HasColumnName("cgrdura")
                    .HasMaxLength(50);

                entity.Property(e => e.Chabilitacaoabate)
                    .HasColumnName("chabilitacaoabate")
                    .HasMaxLength(50);

                entity.Property(e => e.Chl)
                    .HasColumnName("chl")
                    .HasMaxLength(50);

                entity.Property(e => e.Cnomeestocagem)
                    .HasColumnName("cnomeestocagem")
                    .HasMaxLength(50);

                entity.Property(e => e.Cnomeproduto)
                    .HasColumnName("cnomeproduto")
                    .HasMaxLength(250);

                entity.Property(e => e.Csexo)
                    .HasColumnName("csexo")
                    .HasMaxLength(50);

                entity.Property(e => e.Csigla)
                    .HasColumnName("csigla")
                    .HasMaxLength(50);

                entity.Property(e => e.Csisbovidentificador)
                    .HasColumnName("csisbovidentificador")
                    .HasMaxLength(50);

                entity.Property(e => e.Ctipificacaochile)
                    .HasColumnName("ctipificacaochile")
                    .HasMaxLength(50);

                entity.Property(e => e.Ctipoquarto)
                    .HasColumnName("ctipoquarto")
                    .HasMaxLength(50);

                entity.Property(e => e.Ddataabate)
                    .HasColumnName("ddataabate")
                    .HasColumnType("date");

                entity.Property(e => e.Ddataabertura)
                    .HasColumnName("ddataabertura")
                    .HasColumnType("date");

                entity.Property(e => e.Ddatafechamento)
                    .HasColumnName("ddatafechamento")
                    .HasColumnType("date");

                entity.Property(e => e.Ddataproducao)
                    .HasColumnName("ddataproducao")
                    .HasColumnType("date");

                entity.Property(e => e.Ddatavalidade)
                    .HasColumnName("ddatavalidade")
                    .HasColumnType("date");

                entity.Property(e => e.Dza)
                    .HasColumnName("dza")
                    .HasMaxLength(50);

                entity.Property(e => e.Egy)
                    .HasColumnName("egy")
                    .HasMaxLength(50);

                entity.Property(e => e.Fpesoliquido).HasColumnName("fpesoliquido");

                entity.Property(e => e.Fph).HasColumnName("fph");

                entity.Property(e => e.Ibanda).HasColumnName("ibanda");

                entity.Property(e => e.Icodigoempresa).HasColumnName("icodigoempresa");

                entity.Property(e => e.Icodigoestocagem).HasColumnName("icodigoestocagem");

                entity.Property(e => e.Icodigoproduto).HasColumnName("icodigoproduto");

                entity.Property(e => e.Iidade).HasColumnName("iidade");

                entity.Property(e => e.Ilote).HasColumnName("ilote");

                entity.Property(e => e.Irq)
                    .HasColumnName("irq")
                    .HasMaxLength(50);

                entity.Property(e => e.Isequencial).HasColumnName("isequencial");

                entity.Property(e => e.Isif).HasColumnName("isif");

                entity.Property(e => e.Isr)
                    .HasColumnName("isr")
                    .HasMaxLength(50);

                entity.Property(e => e.Kwt)
                    .HasColumnName("kwt")
                    .HasMaxLength(50);

                entity.Property(e => e.Mar)
                    .HasColumnName("mar")
                    .HasMaxLength(50);

                entity.Property(e => e.Mi)
                    .HasColumnName("mi")
                    .HasMaxLength(50);

                entity.Property(e => e.Ne)
                    .HasColumnName("ne")
                    .HasMaxLength(50);

                entity.Property(e => e.Om)
                    .HasColumnName("om")
                    .HasMaxLength(50);

                entity.Property(e => e.Per)
                    .HasColumnName("per")
                    .HasMaxLength(50);

                entity.Property(e => e.Psr)
                    .HasColumnName("psr")
                    .HasMaxLength(50);

                entity.Property(e => e.Sau)
                    .HasColumnName("sau")
                    .HasMaxLength(50);

                entity.Property(e => e.Tun)
                    .HasColumnName("tun")
                    .HasMaxLength(50);

                entity.Property(e => e.Ukr)
                    .HasColumnName("ukr")
                    .HasMaxLength(50);

                entity.Property(e => e.Ury)
                    .HasColumnName("ury")
                    .HasMaxLength(50);

                entity.Property(e => e.Zaf)
                    .HasColumnName("zaf")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
