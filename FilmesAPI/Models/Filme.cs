namespace FilmesAPI.Models
{
    public class Filme(string nome, DateTime dataLancamento, string genero, TimeSpan duracao, string nomeDiretor)
    {
        public string Nome { get; set; } = nome;
        public DateTime DataLancamento { get; set; } = dataLancamento;
        public string Genero { get; set; } = genero;
        public TimeSpan Duracao { get; set; } = duracao;
        public string NomeDiretor { get; set; } = nomeDiretor;
    }
}
