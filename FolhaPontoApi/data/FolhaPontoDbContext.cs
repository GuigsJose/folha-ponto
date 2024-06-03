using FolhaPontoApi.models;
using Microsoft.EntityFrameworkCore;

namespace FolhaPontoApi.data
{
    public class FolhaPontoDbContext : DbContext
    {
        public FolhaPontoDbContext(DbContextOptions<FolhaPontoDbContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios{get;set;}
        public DbSet<Horario> Horarios{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Funcionario>()
                .HasMany(f=>f.Horarios)
                .WithOne(h=>h.Funcionario)
                .HasForeignKey(h=>h.FuncionarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}