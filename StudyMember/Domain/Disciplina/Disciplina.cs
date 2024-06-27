using StudyMember.Domain.Semestres;

namespace StudyMember.Domain
{
  public class Disciplina
  {
    public int nomeDisciplina { get; set; }
    private int idDisciplina { get; }

    private int numFaltasDisciplina { get; set; }
    protected int tempoDeEstudo { get; }
    public int cargaHoraria { get; private set; }

    //colocar em número inteiro (ex: 20% = 20)
    public int percentualDeFaltasPermitidas { get; set; }
    public int faltasRestantes { get; set; }


    public List<Atividade>? listaDeAtividades { get; set; }

    //passando entidade falta, rever talvez incluir como caso de uso
    void adicionarFalta(Falta faltaInput)
    {
      numFaltasDisciplina += faltaInput.HoraAula;
    }

    void removerFalta(int numeroDeFaltas)
    {
      numFaltasDisciplina -= numeroDeFaltas;
    }

    void calcularFaltasRestantes()
    {
            faltasRestantes = (cargaHoraria * percentualDeFaltasPermitidas) / 100;
    }
  }



}
