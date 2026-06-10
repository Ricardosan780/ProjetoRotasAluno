using Microsoft.AspNetCore.Mvc;

namespace ProjetoRotasAluno.Controllers
{
    public class AlunoController : Controller
    {
        // Rota: /Aluno
        public IActionResult Index()
        {
            // Definindo os dados na ViewBag
            ViewBag.Nome = "Ana Carolina Silva";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View();
        }

        // Rota: /Aluno/Detalhes/1
        public IActionResult Detalhes(int id)
        {
            // Passamos o ID recebido pela URL para a ViewBag para conseguirmos exibir na tela
            ViewBag.AlunoId = id;
            
            return View();
        }
    }
}