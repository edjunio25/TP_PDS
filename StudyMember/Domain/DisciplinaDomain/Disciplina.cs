using Falta = StudyMember.Domain.Semestres.Falta;

namespace StudyMember.Domain.DisciplinaDomain
{
    public class Disciplina : IDisciplina
    {
        public int Id { get; set; }
        public int Nome { get; set; }

        public ICollection<Falta> Faltas { get; set; }

        public int TempoDeEstudo { get; set; }

        public int CargaHoraria { get; set; }

        public StatusDisciplina StatusDaDisciplina { get; set; }

        public int NotaTotal { get; set; } 

        public int NotaTotalDistribuida { get; set; }

        public float PercentualDeFaltasPermitidas { get; set; }

        public int FaltasRestantes { get; set; }

        public ICollection<Atividade> Atividades { get; set; }
        private IDisciplinaRepo _repo { get; set; }

        public Disciplina(IDisciplinaRepo repo)
        {
            this.Faltas = new HashSet<Falta>();
            this.Atividades = new HashSet<Atividade>();
            this._repo = repo;
        }

        public void AdicionarFalta(Falta falta)
        {
            _repo.AdicionarFalta(this, falta);
        }

        public void RemoverFalta(int idFalta)
        {
            _repo.RemoverFalta(idFalta);
        }

        public float CalcularFaltasRestantes()
        {
            return ((float)((CargaHoraria * PercentualDeFaltasPermitidas) / 100.0));
        }

        public void AtualizarNotaObtidaeNotaDistribuida()
        {
            float notaTotal = 0.0f, totalDistribuido = 0.0f;
            var atividades = Atividades.ToList();
            var atividadesCount = Atividades.Count;

            if (atividadesCount != 0)
            {
                for (int i = 0; i < Atividades.Count; i++)
                {
                    notaTotal += atividades[i].Nota;
                    totalDistribuido = atividades[i].Valor;
                }
            }

            AtualizarStatusDaDisciplina(notaTotal, totalDistribuido);
        }

        private void AtualizarStatusDaDisciplina(float total, float totalDistribuido)
        {
            if (StatusDaDisciplina != StatusDisciplina.Trancada)
            {
                if (total >= 60.0f)
                {
                    _repo.AtualizarStatus(StatusDisciplina.Aprovada);
                    StatusDaDisciplina = StatusDisciplina.Aprovada;
                }
                else if ((total + (100 - totalDistribuido)) < 60)
                {
                    _repo.AtualizarStatus(StatusDisciplina.Reprovada);
                    StatusDaDisciplina = StatusDisciplina.Reprovada;
                }
                else
                {
                    _repo.AtualizarStatus(StatusDisciplina.Cursando);
                    StatusDaDisciplina = StatusDisciplina.Cursando;
                }
            }

        }
    }

    public enum StatusDisciplina
    {
        Cursando,
        Aprovada,
        Reprovada,
        Trancada
    }



}
