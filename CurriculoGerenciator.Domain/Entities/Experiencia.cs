using CurriculoGerenciator.Domain.Interfaces;

namespace CurriculoGerenciator.Domain.Entities
{
    public class Experiencia : BaseDomain, IExibivel
    {
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataSaida { get; set; }
        public string Atividades { get; set; }
        public bool Atual { get; set; }
        public bool Ativo { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
