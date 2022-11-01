using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Tarcísio",
                Email = "tarcisiokta2012@gmail.com",
                DataNascimento = DateTime.Now
            };

            _contexto.Add(aluno);
            _contexto.SaveChanges();

            return View();
        }
    }
}
