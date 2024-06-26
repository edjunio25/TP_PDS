using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities
{
    public class Falta
    {
        [Key]
        public int Id { get;  set; }
        public DateTime ?DataFalta { get; set; }
        public DateTime ?DataDeRegistro { get; set; }
        public int ?HoraAula { get; set; }
        public string? Justificativa { get; set; }
        public string? LinkAnexo { get; set; }
    }
}
