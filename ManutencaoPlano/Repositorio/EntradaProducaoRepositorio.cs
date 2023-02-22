using ManutencaoPlano.Data;
using ManutencaoPlano.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManutencaoPlano.Repositorio
{
    public class EntradaProducaoRepositorio : IEntradaProducaoRepositorio
    {
        private readonly planodiarioContext _planodiarioContext;

        public EntradaProducaoRepositorio(planodiarioContext planodiarioContext)
        {
            _planodiarioContext = planodiarioContext;
        }
        public List<FtAbateQuarteioHabilitacao> BuscarTodos()
        {
            return _planodiarioContext.FtAbateQuarteioHabilitacao.Where(x => x.Ncdhistoricosaida == null
                && x.Ncdempresaabate == 182 && x.Dmovimento == Convert.ToDateTime("2023-01-25")).ToList();
        }
    }
}
