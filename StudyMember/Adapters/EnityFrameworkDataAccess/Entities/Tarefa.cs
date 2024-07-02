using StudyMember.Domain;
using System.ComponentModel.DataAnnotations;

namespace StudyMember.Adapters.EnityFrameworkDataAccess.Entities
{
    public class Tarefa
    {
        [Key]
        public int Id { get; }
        public int IdAtividade { get; set; }
        public DateTime DataTermino { get; set; }
        public DateTime DataCriacao { get; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public TiposDeTarefa Tipo;
    }
}
