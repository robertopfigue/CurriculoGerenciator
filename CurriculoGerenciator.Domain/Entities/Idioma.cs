using CurriculoGerenciator.Domain.Interfaces;

namespace CurriculoGerenciator.Domain.Entities
{
    public class Idioma : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Nivel { get; set; }
        public bool Ativo { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
