using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("Produtos")]
    public class CadastroController : Controller
    {
        [Route("Lista")]
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Busca()
        {
            return View();
        }
    }
}
