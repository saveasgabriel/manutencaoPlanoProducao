using System.Collections.Generic;
using ManutencaoPlano.Models;

namespace ManutencaoPlano.ViewModels
{
    public class EntradaProducaoViewModel
    {
        public IEnumerable<ViewDisponibilidadeQuartos> DisponibilidadeQuartos { get; set;}

        public List<string> ListaEmpresa { get; set;}
    }
}