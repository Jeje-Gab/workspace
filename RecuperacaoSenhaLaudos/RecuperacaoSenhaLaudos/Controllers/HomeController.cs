using Microsoft.AspNetCore.Mvc;
using RecuperacaoSenhaLaudos.DTOs;
using RecuperacaoSenhaLaudos.Models;
using RecuperacaoSenhaLaudos.Services;
using System.Diagnostics;

namespace RecuperacaoSenhaLaudos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRecuperarSenhaLaudosServices _recuperarSenhaLaudosService;


        public HomeController(ILogger<HomeController> logger,
            IRecuperarSenhaLaudosServices recuperarSenhaLaudosService)
        {
            _logger = logger;
            _recuperarSenhaLaudosService = recuperarSenhaLaudosService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DadosSenha()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(BuscarSenhasLaudos buscarSenhasLaudos)
        // RRetorna-se para o Index o "Model" onde tera a lista de itens, despesas e datas 
        {
            // Try para caso surja uma exeption
            try
            {
                buscarSenhasLaudos.Pessoa = await _recuperarSenhaLaudosService.BuscarSenhasLaudos(buscarSenhasLaudos.CPF, buscarSenhasLaudos.NomeCompleto, buscarSenhasLaudos.NomeMaeCompleto, buscarSenhasLaudos.DataNascimento);

                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CustomError", ex.Message);
                return View(buscarSenhasLaudos);
            }


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}