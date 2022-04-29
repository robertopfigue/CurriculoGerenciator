using CurriculoGerenciator.Domain.Interfaces;

namespace CurriculoGerenciator.Domain.Entities
{
    public class DadosPessoa : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
