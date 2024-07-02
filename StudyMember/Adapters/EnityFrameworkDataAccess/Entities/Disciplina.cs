using StudyMember.Domain.DisciplinaDomain;
using StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities;
using System.ComponentModel.DataAnnotations;

namespace StudyMember.Adapters.EnityFrameworkDataAccess.Entities
{
    public class Disciplina
    {
        [Key]
        public int Id { get; set; }
        public int Nome { get; set; }
        public Semestre? Semestre { get; set; }
        public ICollection<Falta> Faltas { get; set; }
        public int TempoDeEstudo { get; set; }
        public int CargaHoraria { get; set; }
        public StatusDisciplina StatusDaDisciplina { get; set; }
        public int NotaTotal { get; set; }
        public int NotaTotalDistribuida { get; set; }
        public float PercentualDeFaltasPermitidas { get; set; }
        public int FaltasRestantes { get; set; }
        public ICollection<Atividade> Atividades { get; set; }
        public Disciplina()
        {
            this.Faltas = new HashSet<Falta>();
            this.Atividades = new HashSet<Atividade>();
        }
    }
}
