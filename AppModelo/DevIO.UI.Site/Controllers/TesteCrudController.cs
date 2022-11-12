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

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            aluno2.Nome = "Tarcísio Carvalho";

            _contexto.Alunos.Update(aluno2);
            _contexto.SaveChanges();

            var aluno3 = _contexto.Alunos.Find(aluno.Id);
            _contexto.Alunos.Remove(aluno3);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}
