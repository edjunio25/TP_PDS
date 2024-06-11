namespace StudyMember.ClientApp.src.core.dominio

{
    public class Atividade
    {
    private int idAtividade;
    public string nomeAtividade;
    public Data dataEntregaAtividade;
    public AtvidadeTipo tipoDaAtividade;
    public int valor;
    public int nota;

    public Atividade( string nomeInput, Data dataInput, AtividadeTipo tipoInput, int valorInput)
    {
      //TODO implementar ID único ou sequencial ou aleatório

      nomeAtividade = nomeInput;
      dataEntregaAtividade = dataInput;
      tipoDaAtividade = tipoInput;
      valor = valorInput;
    }
    int getIdAtividade()
    {
      return idAtividade;
    }

    }

  enum AtividadeTipo
  {
    prova,
    atividadeIsolada,
    trabalho
  }
}
