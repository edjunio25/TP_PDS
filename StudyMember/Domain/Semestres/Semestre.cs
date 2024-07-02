using StudyMember.Domain.DisciplinaDomain;

namespace StudyMember.Domain.Semestres
{
    public class Semestre : ISemestre
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public int SemestreReferencia { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        private ISemestreRepo? _repo { get; set; }

        public Semestre(ISemestreRepo repo)
        {
            this.Disciplinas = new List<Disciplina>();
            this._repo = repo;
        }

        public Semestre(int Id, int ano, int SemestreReferencia) 
        { 
            this.Id = Id;
            this.Ano = ano;
            this.SemestreReferencia = SemestreReferencia;
            this.Disciplinas = new List<Disciplina>();
        }

        public Semestre GetSemestre(int id)
        {
            var semestre = _repo.GetSemestreAsync(id).Result;
            return new Semestre(semestre.Id, semestre.Ano, semestre.SemestreReferencia);
        }
    }
}
