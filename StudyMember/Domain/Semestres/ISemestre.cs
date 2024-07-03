using StudyMember.Models;

namespace StudyMember.Domain.Semestres
{
    public interface ISemestre
    {
        public Semestre GetSemestre(int id);
        public List<Semestre> GetSemestres(string idAluno);
        public bool PostSemester(Semestre semestre, ApplicationUser user);
    }
}
