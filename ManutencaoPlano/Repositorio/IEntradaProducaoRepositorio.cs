using System.Collections.Generic;
using System.Threading.Tasks;
using ManutencaoPlano.Models;


namespace ManutencaoPlano.Repositorio
{
    public interface IEntradaProducaoRepositorio
    {
        IEnumerable<ViewDisponibilidadeQuartos> BuscarPorTipo(string tipo, string unidade);

    }

 
}
