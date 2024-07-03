using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudyMember.Adapters.EnityFrameworkDataAccess.Repos;
using StudyMember.Data;
using StudyMember.Domain.Semestres;
using StudyMember.Models;
using static Duende.IdentityServer.Models.IdentityResources;

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

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Semestre semestre, [FromQuery] string email)
    {
        if (semestre == null)
        {
            return BadRequest("Semestre is null");
        }

        var user = await _userManager.FindByEmailAsync(email);
        var repo = new SemestreRepo(_context);
        var semestreObj = new Semestre(repo);
        // Implement the logic to save the semestre object to the database
        // For example:
        try
        {
            var result = semestre.PostSemester(semestreObj, user);
            if (result)
            {
                return Ok(semestre);
            }
            else
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}

