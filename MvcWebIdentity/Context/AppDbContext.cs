using Microsoft.EntityFrameworkCore;
using MvcWebIdentity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcWebIdentity.Context;

public class AppDbContext : IdentityDbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
        
    public DbSet<Aluno> Alunos { get; set; }

    internal static object CreateBuilder(string[] args)
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Aluno>().HasData(
            new Aluno
            {
                AlunoId = 1,
                Nome = "RodPeixoto",
                Email = "rodpeixoto@outlook.com",
                Idade = 23,
                Curso = "Filosofia"

            });
    }
}
