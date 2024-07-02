using Microsoft.EntityFrameworkCore;
using StudyMember.Data;
using StudyMember.Domain.Semestres;

namespace StudyMember.Adapters.EnityFrameworkDataAccess.Repos
{
    public class SemestreRepo : ISemestreRepo
    {
        private readonly ApplicationDbContext _context;

        public SemestreRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Infrastructure.EnityFrameworkDataAccess.Entities.Semestre> GetSemestreAsync(int id)
        {
            return await _context.Semestres.FirstOrDefaultAsync(m => m.Id == id);
        }

        public bool AddSemestreAsync(Infrastructure.EnityFrameworkDataAccess.Entities.Semestre semestre)
        {
            var result = _context.Semestres.Add(semestre);
            _context.SaveChanges();

            return result == null;
        }
    }
}
