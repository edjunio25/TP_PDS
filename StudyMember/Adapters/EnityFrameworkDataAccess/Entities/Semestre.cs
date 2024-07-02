using StudyMember.Adapters.EnityFrameworkDataAccess.Entities;
using StudyMember.Models;
using System.ComponentModel.DataAnnotations;

namespace StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities
{
    public class Semestre
    {
        [Key]
        public int Id { get; set; }
        public int Ano { get; private set; }
        public ApplicationUser? Aluno { get; set; }
        public string AlunoId { get; set; }
        public int SemestreReferencia { get; set; }
        public ICollection<Disciplina> Disciplinas { get; set; }
        public Semestre()
        {
            Disciplinas = new HashSet<Disciplina>();
        }
    }
}
