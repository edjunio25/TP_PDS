namespace StudyMember.ClientApp.src.core.dominio
{
  public class TarefaAgendada
  {
    private readonly int idTarefa {  get; }
    private int idAtividade { get; set; }
    public Data dataTermino { get; set; }
    public readonly Data dataCriacaoDaTarefa { get; }
    public string nomeTarefa { get; set; }
    public string descricaoTarefa { get; set; }

    // Uma ideia, utilizar o tipo para determinar a cor da tarefa na interface depois
    // A avaliar viabilidade
    public int tipoTarefa;

    public void TarefaAgendada (string nomeTarefaInput, Data dataTerminoInput, string descricaoInput, int idAtividadeInput)
    {
      nomeTarefa = nomeTarefaInput;
      dataTermino = dataTerminoInput;
      descricaoTarefa = descricaoInput;
      idAtividade = idAtividadeInput;

      // Automaticos
      dataCriacaoDaTarefa.obterDataDeAgora();
      idTarefa; // TODO Implementar id unico

    }


  }

  public class enum tiposDeTarefa
  {
    atividade,
    prova,
    trabalhoTarefa,
    trabalhoEntrega,
    reunião,
    evento;
  }
}
