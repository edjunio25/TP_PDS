using System.ComponentModel.DataAnnotations;

namespace StudyMember.Domain.Semestres
{
    public class Falta
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DataFalta { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public int HoraAula { get; set; }
        public string? Justificativa { get; set; }
        public string? LinkAnexo { get; set; }

    }
}
