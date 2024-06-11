namespace StudyMember.ClientApp.src.core.dominio
{
  public class Disciplina
  {
    public int nomeDisciplina { get; set; }
    private readonly int idDisciplina { get; }
    private int numFaltasDisciplina { get; }
    protected int tempoDeEstudo { get; }
    public List<Atividade> listaDeAtividades { get; set; }


    void adicionarFalta(int numeroDeFaltas)
    {
      numFaltasDisciplina += numeroDeFaltas;
    }

    void removerFalta(int numeroDeFaltas)
    {
      numFaltasDisciplina -= numeroDeFaltas;
    }
  }



}
