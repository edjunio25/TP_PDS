using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyMember.Adapters.EnityFrameworkDataAccess.Repos;
using StudyMember.Data;
using StudyMember.Domain.Semestres;
using StudyMember.Models;

namespace StudyMember.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class SemestreController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    public SemestreController(ApplicationDbContext context, UserManager<ApplicationUser> userManager) 
    {
        _context = context;
        _userManager = userManager;
    }
    [HttpGet]
    public async Task<List<Semestre>> Get([FromQuery] string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        var repo = new SemestreRepo(_context);
        var semestre = new Semestre(repo);
        return semestre.GetSemestres(user.Id);
    }
}

