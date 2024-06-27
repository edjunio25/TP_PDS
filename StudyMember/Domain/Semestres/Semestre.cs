using System.Collections.Generic;

namespace StudyMember.Domain.Semestre.Semestre.cs
{
    public class Semestre
    {
    public Guid semestreId { get; private set; }
    public int ano { get; private set; }
    public int semestreReferencia { get; private set; }
    public List<int>? listaIdsDisciplinas;
    public List<int>? listaIdsTarefas;

    public Semestre(int ano, int semestreReferencia)
        {
            semestreId = Guid.NewGuid();
            this.ano = ano;
            this.semestreReferencia = semestreReferencia;
            listaIdsDisciplinas = new List<int>();
        }

    }



}
