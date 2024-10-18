using FilmesAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private List<Filme> _filmes;

        public FilmeController()
        {
            _filmes = new()
            {
                new Filme("10 Coisas Que Eu Odeio Em Você", new DateTime(1999, 3, 31), "Comédia Romântica", new TimeSpan(1, 37, 0), "Gil Junger"),
                new Filme("Como Perder um Homem Em 10 Dias", new DateTime(2003, 1, 27), "Comédia Romântica", new TimeSpan(1, 56, 0), "Donald Petrie"),
                new Filme("Mamma Mia!", new DateTime(2008, 9, 12), "Musical", new TimeSpan(1, 48, 0), "Phyllida Lloyd")
            };
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Obter()
        {
            return Ok(_filmes);
        }
    }
}
