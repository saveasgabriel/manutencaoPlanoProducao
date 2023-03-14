using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ManutencaoPlano.Models
{
    public partial class ViewDisponibilidadeQuartos
    {
        public int? Icodigoempresa { get; set; }
        public string Csigla { get; set; }
        public int? Isif { get; set; }

        [DisplayName("Fechamento")]
        public DateTime? Ddatafechamento { get; set; }
        public string Ctipoquarto { get; set; }

        [DisplayName("Estocagem")]
        public string Ccamaradeestocagem { get; set; }

        [DisplayName("Qtd Pçs")]
        public long? Total { get; set; }

        [DisplayName("CHL")]
        public long? Chl { get; set; }

        [DisplayName("SAU")]
        public long? Sau { get; set; }

        [DisplayName("EGY")]
        public long? Egy { get; set; }

        [DisplayName("PSR")]
        public long? Psr { get; set; }

        [DisplayName("MI")]
        public long? Mi { get; set; }

        [DisplayName("Até 2=")]
        public long? Ate2 { get; set; }

        [DisplayName("2+")]
        public long? _2 { get; set; }

        [DisplayName("3-")]
        public long? _3 { get; set; }

        [DisplayName("3=")]
        public long? _31 { get; set; }

        [DisplayName("3+ UP")]
        public long? _3Up { get; set; }

        [DisplayName("PESO")]
        public double? Media { get; set; }
    }


}
