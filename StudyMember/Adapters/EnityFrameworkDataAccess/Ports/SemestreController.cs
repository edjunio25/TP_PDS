using Microsoft.AspNetCore.Mvc;
using StudyMember.Adapters.EnityFrameworkDataAccess.Repos;
using StudyMember.Data;
using StudyMember.Domain.Semestres;

namespace StudyMember.Adapters.EnityFrameworkDataAccess.Ports
{
    public class SemestreController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SemestreController(ApplicationDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public Semestre Get([FromQuery] int id)
        {
            var repo = new SemestreRepo(_context);
            var semestre = new Semestre(repo);
            return semestre.GetSemestre(id);
        }
    }
}
