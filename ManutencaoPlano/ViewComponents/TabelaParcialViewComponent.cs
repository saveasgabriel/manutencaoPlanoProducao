using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ManutencaoPlano.Models;
using ManutencaoPlano.Data;
using ManutencaoPlano.Repositorio;
using ManutencaoPlano.Controllers;
using ManutencaoPlano.ViewModels;

namespace ManutencaoPlano.ViewComponents
{
    public class TabelaParcialViewComponent : ViewComponent
    {
        private readonly IEntradaProducaoRepositorio _entradaProducaoRepositorio;

        public TabelaParcialViewComponent(IEntradaProducaoRepositorio entradaProducaoRepositorio)
        {
            _entradaProducaoRepositorio = entradaProducaoRepositorio;
        }

        public async Task<IViewComponentResult> InvokeAsync(string tipo, string unidade)
        {
   
            var tabela = _entradaProducaoRepositorio.BuscarPorTipo(tipo, unidade);

            return View(tabela);

        }
    }
}
