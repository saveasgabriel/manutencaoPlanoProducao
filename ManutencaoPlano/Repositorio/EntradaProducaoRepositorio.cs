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

        public IEnumerable<ViewDisponibilidadeQuartos> BuscarPorTipo(string tipo, string unidade)
        {
            if (unidade == null )            
            {
                return _planodiarioContext.ViewDisponibilidadeQuartos
                .Where(x => x.Ctipoquarto == tipo)
                .OrderBy(o => o.Ddatafechamento)
                .ToList();

            }
            else
            {
                return _planodiarioContext.ViewDisponibilidadeQuartos
                .Where(x => x.Ctipoquarto == tipo &&
                    x.Csigla == unidade)
                .OrderBy(o => o.Ddatafechamento)
                .ToList();
            }
        }        
    }
}
