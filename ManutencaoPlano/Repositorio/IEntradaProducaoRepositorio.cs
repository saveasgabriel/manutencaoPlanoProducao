using System.Collections.Generic;
using System.Threading.Tasks;
using ManutencaoPlano.Models;


namespace ManutencaoPlano.Repositorio
{
    public interface IEntradaProducaoRepositorio
    {
        IEnumerable<FtAbateQuarteioHabilitacao> BuscarTodos();

        IEnumerable<FtAbateQuarteioHabilitacao> BuscarPorTipo(string tipo, int unidade);

    }

 
}
