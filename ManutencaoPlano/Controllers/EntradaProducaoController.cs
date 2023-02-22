using ManutencaoPlano.Models;
using ManutencaoPlano.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ManutencaoPlano.Controllers
{
    public class EntradaProducaoController : Controller
    {
        private readonly IEntradaProducaoRepositorio _entradaProducaoRepositorio;
        public EntradaProducaoController (IEntradaProducaoRepositorio entradaProducaoRepositorio)
        {
            _entradaProducaoRepositorio = entradaProducaoRepositorio;
        }

        public IActionResult Index()
        {
            List<FtAbateQuarteioHabilitacao> dados = _entradaProducaoRepositorio.BuscarTodos();
            return View(dados);
        }
    }
}
