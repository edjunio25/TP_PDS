using StudyMember.Domain.Semestres;

namespace StudyMember.Domain.DisciplinaDomain
{
    public interface IDisciplina
    {
        public void AdicionarFalta(Falta falta);
        public void AtualizarNotaObtidaeNotaDistribuida();
        public void RemoverFalta(int idFalta);
    }
}