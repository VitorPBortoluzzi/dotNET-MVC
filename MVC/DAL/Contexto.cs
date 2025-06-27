using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.DAL
{
    public class Contexto :DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Projeto)
                .WithMany(p => p.Tarefas)
                .HasForeignKey(t => t.ProjetoId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
