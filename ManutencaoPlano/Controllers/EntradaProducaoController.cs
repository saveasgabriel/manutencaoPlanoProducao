using ManutencaoPlano.Data;
using ManutencaoPlano.Models;
using ManutencaoPlano.Repositorio;
using ManutencaoPlano.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ManutencaoPlano.Controllers
{
    public class EntradaProducaoController : Controller
    {

        private readonly IEntradaProducaoRepositorio _entradaProducaoRepositorio;

        public EntradaProducaoController(IEntradaProducaoRepositorio entradaProducaoRepositorio)
        {
            _entradaProducaoRepositorio = entradaProducaoRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tabela(string tipo, string unidade)
        {
            ViewBag.PlantaAtual = unidade;
            ViewBag.TipoAtual = tipo;

            var entradaProducaoViewModel = new EntradaProducaoViewModel();
            
            entradaProducaoViewModel.DisponibilidadeQuartos = _entradaProducaoRepositorio.BuscarPorTipo(tipo, unidade); 

            List<string> SiglasEmpresas = (from siglas in entradaProducaoViewModel.DisponibilidadeQuartos
                select siglas.Csigla).Distinct().ToList();

            List<DateTime?> DtFechamento = (from fechamento in entradaProducaoViewModel.DisponibilidadeQuartos
                select fechamento.Ddatafechamento).Distinct().ToList();

            List<string> Camaras = (from cm in entradaProducaoViewModel.DisponibilidadeQuartos
                select cm.Ccamaradeestocagem).Distinct().ToList();

            var Tipo = (from tp in entradaProducaoViewModel.DisponibilidadeQuartos
                           select tp.Ctipoquarto).Distinct().ToString();

            ViewBag.Siglas = SiglasEmpresas;
            ViewBag.DtFechamento = DtFechamento;
            ViewBag.Camaras = Camaras;
            
            

            return View(entradaProducaoViewModel);
        }

        public IActionResult TabelaParcial(string tipo, string unidade)
        {
            return ViewComponent("TabelaParcial",
                new
                {
                    tipo = tipo,
                    unidade = unidade
                }
            );
        }
        

    }
}
