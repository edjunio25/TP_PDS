using StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities;

namespace StudyMember.Domain.Semestres
{
    public interface ISemestreRepo
    {
        public Task<StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities.Semestre> GetSemestreAsync(int id);
    }
}
