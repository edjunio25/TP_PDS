namespace StudyMember.Domain
{
  public class TarefaAgendada
  {
    public int Id {  get; }
    public int IdAtividade { get; set; }
    public DateTime DataTermino { get; set; }
    public  DateTime DataCriacao { get; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public TiposDeTarefa Tipo;

    public TarefaAgendada()
    {

    }
  }

  public enum TiposDeTarefa
  {
    atividade,
    prova,
    trabalhoTarefa,
    trabalhoEntrega,
    reunião,
    evento
  }
}
