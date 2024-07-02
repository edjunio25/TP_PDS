using StudyMember.Domain.DisciplinaDomain;
using StudyMember.Domain.Semestres;

namespace StudyMember.Adapters.EnityFrameworkDataAccess.Repos
{
    public class DisciplinaRepo : IDisciplinaRepo
    {
        public bool AdicionarFalta(Disciplina disciplina, Falta falta)
        {
            throw new NotImplementedException();
        }

        public void AtualizarStatus(StatusDisciplina cursando)
        {
            throw new NotImplementedException();
        }

        public void RemoverFalta(int idFalta)
        {
            throw new NotImplementedException();
        }
    }
}
