using ManutencaoPlano.Data;
using ManutencaoPlano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManutencaoPlano.Repositorio
{
    public class EntradaProducaoRepositorio : IEntradaProducaoRepositorio
    {
        private readonly planodiarioContext _planodiarioContext;

        public EntradaProducaoRepositorio(planodiarioContext planodiarioContext)
        {
            _planodiarioContext = planodiarioContext;
        }

        public IEnumerable<FtAbateQuarteioHabilitacao> BuscarPorTipo(string tipo, int unidade)
        {
            return _planodiarioContext.FtAbateQuarteioHabilitacao
                .Where(x => x.Cquarto == tipo && 
                    x.Ncdempresaproducao == unidade && x.Ncdhistoricosaida == null)
                .OrderBy(x => x.Isequencial);
                
        }

        public IEnumerable<FtAbateQuarteioHabilitacao> BuscarTodos()
        {

            var tabela = _planodiarioContext.FtAbateQuarteioHabilitacao
                .Where(x => x.Ncdhistoricosaida == null
                        && x.Ncdempresaabate == 182 && x.Dmovimento == Convert.ToDateTime("2023-01-25"))
                .OrderBy(x => x.Isequencial)
                .ToList();
            

            return tabela;
        }

        
    }
}
