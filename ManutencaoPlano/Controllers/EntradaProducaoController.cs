using ManutencaoPlano.Data;
using ManutencaoPlano.Models;
using ManutencaoPlano.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ManutencaoPlano.Controllers
{
    public class EntradaProducaoController : Controller
    {

        private readonly planodiarioContext _planodiarioContext;

        public EntradaProducaoController(planodiarioContext planodiarioContext)
        {
            _planodiarioContext = planodiarioContext;
        }

        //private readonly IEntradaProducaoRepositorio _entradaProducaoRepositorio;
        //public EntradaProducaoController (IEntradaProducaoRepositorio entradaProducaoRepositorio)
        //{
        //    _entradaProducaoRepositorio = entradaProducaoRepositorio;
        //}

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tabela(string tipo, int unidade)
        {
            //IEnumerable<FtAbateQuarteioHabilitacao> dados = _entradaProducaoRepositorio.BuscarPorTipo(tipo, unidade);

            IEnumerable<ViewDisponibilidadeQuartos> tabela = _planodiarioContext.ViewDisponibilidadeQuartos
                .Where(x => x.Ctipoquarto == tipo &&
                    x.Icodigoempresa == unidade)
                .ToList();

            var result = from tb in tabela
                         select tb;
            



            return View(tabela);
        }

    }
}
