using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaEstudos.Models.Repository {
    public class EFTarefaRepository : ITarefaRepository {

        private readonly AgendaEstudosDbContext _context;

        public EFTarefaRepository(AgendaEstudosDbContext ctx) {
            _context = ctx;
        }

        public void CreateTarefa(Tarefa tarefa) {
            _context.Add(tarefa);
            _context.SaveChanges();
        }

        public Tarefa GetById(long id) {
            return _context.Tarefas.FirstOrDefault(t => t.TarefaID == id);
        }

        public void Atualizar(Tarefa tarefa) {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
        }

        public IEnumerable<Tarefa> ListarTarefas() {
            return _context.Tarefas;
        }

        public void DeletarTarefa(Tarefa tarefa) {
            Console.WriteLine("Deletando:" + tarefa);
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();

        }
    }
}