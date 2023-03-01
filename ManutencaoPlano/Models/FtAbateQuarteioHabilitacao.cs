using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ManutencaoPlano.Models
{   
    public partial class FtAbateQuarteioHabilitacao
    {
        [DisplayName("Banco")]
        public string Cbd { get; set; }

        [DisplayName("Data")]
        public DateTime? Dmovimento { get; set; }

        [DisplayName("Sequencial")]
        public int? Isequencial { get; set; }

        public int? Ibanda { get; set; }

        [DisplayName("Cód Empresa")]
        public int? Ncdempresaabate { get; set; }
        public int? Ncdempresaproducao { get; set; }
        public int? Ncdproduto { get; set; }

        [DisplayName("Tipo")]
        public string Cquarto { get; set; }
        public string Ccdbarra { get; set; }
        public DateTime? Dvalidade { get; set; }
        public double? Npesobruto { get; set; }
        public int? Iidade { get; set; }

        [DisplayName("Sexo")]
        public string Csexo { get; set; }

        [DisplayName("Peso")]
        public double? Npeso { get; set; }
        public int? Ncdhistoricoentrada { get; set; }
        public DateTime? Dentradaestoque { get; set; }

        [DisplayName("Motivo Saída")]
        public int? Ncdhistoricosaida { get; set; }
        public DateTime? Dsaidaestoque { get; set; }
        public int? Ncdcaracteristica { get; set; }
        public int? Ncdhabilitacaocompragado { get; set; }
        public int? Ncdhabilitacaocalhasangria { get; set; }
        public int? Ncdhabilitacaotipificacao { get; set; }

        [DisplayName("Habilitação")]
        public int? Ncdhabilitacaocamara { get; set; }
        public int? Ncdhabilitacaotransferencia { get; set; }
        public int? Ncdhabilitacaoordemproducao { get; set; }
        public int? Ncdordemproducao { get; set; }
        public int? Ncdtipoproducao { get; set; }
        public int? Ncdhabilitacaoescala { get; set; }
        public int? Ncdhabilitacaorecebimento { get; set; }
    }

}
