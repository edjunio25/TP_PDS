using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using StudyMember.Models;
using StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace StudyMember.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {
        
    }

    public DbSet<Falta> Faltas { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Falta>().HasKey(d => d.Id);
    }
}
