using System;
using AgendaEstudos.Migrations;
using Microsoft.EntityFrameworkCore;

namespace AgendaEstudos.Models {
    public class AgendaEstudosDbContext : DbContext {
        
        public DbSet<Tarefa> Tarefas {get; set; }
        
        public AgendaEstudosDbContext(DbContextOptions<AgendaEstudosDbContext> options)
            : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Tarefa>()
                .Property(p => p.CriadaEm)
                .HasDefaultValue(DateTime.Now);
        }
    }
}