using Microsoft.AspNetCore.Identity;
using StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities;

namespace StudyMember.Models;

public class ApplicationUser : IdentityUser
{
    public ICollection<Semestre> Semestres { get; set; }

    public ApplicationUser()
    {
        this.Semestres = new HashSet<Semestre>();
    }
}
