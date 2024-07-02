using StudyMember.Domain;
using System.ComponentModel.DataAnnotations;

namespace StudyMember.Adapters.EnityFrameworkDataAccess.Entities
{
    public class Atividade
    {
        [Key]
        public int Id { get; set; }
        public Disciplina? Disciplina { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeInclusaoAtividade { get; set; }
        public DateTime DataPrazoAtividade { get; set; }
        public DateTime? DataEntregaAtividade { get; set; }
        public AtividadeTipo TipoDaAtividade { get; set; }
        public StatusAtividade? StatusDaAtividade { get; set; }
        public float Valor { get; set; }
        public float Nota { get; set; }
    }
}
