using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid) { }

            return View(filme);
        }
    }
}
