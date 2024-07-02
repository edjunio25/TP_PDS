using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using StudyMember.Models;
using StudyMember.Infrastructure.EnityFrameworkDataAccess.Entities;
using StudyMember.Adapters.EnityFrameworkDataAccess.Entities;

namespace StudyMember.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {
        
    }

    public DbSet<Falta> Faltas { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }
    public DbSet<Semestre> Semestres { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Falta>().HasKey(f => f.Id);
        builder.Entity<Falta>(f =>
        {
            f.HasOne(f => f.Disciplina)
             .WithMany(d => d.Faltas)
             .HasForeignKey(f => f.DisciplinaId)
             .HasConstraintName("DisciplinaFaltaFKConstraint");
        });

        builder.Entity<Disciplina>(d =>
        {
            d.HasMany(d => d.Atividades)
            .WithOne(a => a.Disciplina)
            .HasForeignKey(a => a.Id)
            .HasConstraintName("DisciplinaAtividadeFKConstraint");

            d.HasMany(f => f.Faltas)
            .WithOne(a => a.Disciplina)
            .HasForeignKey(a => a.DisciplinaId)
            .HasConstraintName("DisciplinaFaltaFKConstraint");
        });

        builder.Entity<Semestre>(s =>
        {
            s.HasMany(d => d.Disciplinas)
            .WithOne(a => a.Semestre)
            .HasForeignKey(a => a.Id)
            .HasConstraintName("SemestreDisciplinaFKConstraint");

            s.HasOne(u => u.Aluno)
            .WithMany(s => s.Semestres)
            .HasForeignKey(a => a.AlunoId)
            .HasConstraintName("SemestreAlunoFKConstraint");
        });
    }
}
