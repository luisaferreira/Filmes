using FilmesAPI.Controllers;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Tests
{
    public class FilmesTest
    {
        [Fact]
        public void Obter_DeveRetornarListaDeFilmes()
        {
            var controller = new FilmeController();
            var resultado = controller.Obter();

            var okResult = Assert.IsType<OkObjectResult>(resultado);
            var filmes = Assert.IsType<List<Filme>>(okResult.Value);

            Assert.Equal(3, filmes.Count);
        }

        [Fact]
        public void Obter_DeveRetornarTituloPrimeiroFilme()
        {
            var controller = new FilmeController();
            var resultado = controller.Obter();

            var okResult = Assert.IsType<OkObjectResult>(resultado);
            var filmes = Assert.IsType<List<Filme>>(okResult.Value);

            Assert.Equal("10 Coisas Que Eu Odeio Em Você", filmes[0].Nome);
        }
    }
}