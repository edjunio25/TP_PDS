using StudyMember.Domain.Semestres;

namespace StudyMember.Domain.DisciplinaDomain
{
    public interface IDisciplinaRepo
    {
        public bool AdicionarFalta(Disciplina disciplina, Falta falta);
        void AtualizarStatus(StatusDisciplina cursando);
        public void RemoverFalta(int idFalta);
    }
}
