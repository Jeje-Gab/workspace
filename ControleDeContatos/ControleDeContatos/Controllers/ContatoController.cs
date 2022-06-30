using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Action que cria um novo contato e o add a lista
        public IActionResult Criar()
        {
            return View();
        }

        // Action que Edita um contato existente
        public IActionResult Editar()
        {
            return View();
        }

        // Action que apaga um contato desejado
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}
