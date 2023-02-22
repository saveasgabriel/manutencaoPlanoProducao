using System.Collections.Generic;
using ManutencaoPlano.Models;

namespace ManutencaoPlano.Repositorio
{
    public interface IEntradaProducaoRepositorio
    {
        List<FtAbateQuarteioHabilitacao> BuscarTodos();
    }
}
