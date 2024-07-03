using StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities;

namespace StudyMember.Domain.Semestres
{
    public interface ISemestreRepo
    {
        public Task<StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities.Semestre> GetSemestreAsync(int id);
        public List<StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities.Semestre> GetSemestresAsync(string idAluno);
        public bool PostSemestreAsync(StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities.Semestre aluno);
    }
}
