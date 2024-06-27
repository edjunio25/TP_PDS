namespace StudyMember.Domain
{
  public class TarefaAgendada
  {
    private int idTarefa {  get; }
    private int idAtividade { get; set; }
    public DateTime dataTermino { get; set; }
    public  DateTime dataCriacaoDaTarefa { get; }
    public string nomeTarefa { get; set; }
    public string descricaoTarefa { get; set; }

    // Uma ideia, utilizar o tipo para determinar a cor da tarefa na interface depois
    // A avaliar viabilidade
    public int tipoTarefa;

    public TarefaAgendada (string nomeTarefaInput, DateTime dataTerminoInput, string descricaoInput, int idAtividadeInput)
    {
      nomeTarefa = nomeTarefaInput;
      dataTermino = dataTerminoInput;
      descricaoTarefa = descricaoInput;
      idAtividade = idAtividadeInput;

      // Automaticos
      dataCriacaoDaTarefa = DateTime.Now;
      // TODO Implementar id unico

    }


  }

  public enum tiposDeTarefa
  {
    atividade,
    prova,
    trabalhoTarefa,
    trabalhoEntrega,
    reunião,
    evento
  }
}
