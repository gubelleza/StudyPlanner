using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public void Atualizar(IEnumerable<Tarefa> tarefas) {
            _context.Tarefas.UpdateRange(tarefas);
            _context.SaveChanges();
        }

        public IEnumerable<Tarefa> ListarTarefas() {
            return _context.Tarefas;
        }

        public void DeletarTarefa(Tarefa tarefa) {
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
        }

        public void DeletarTarefas(IEnumerable<Tarefa> tarefas) {
            _context.Tarefas.RemoveRange(tarefas);
            _context.SaveChanges();
        }
        
        public void ReiniciarHorasEstudadas(IEnumerable<Tarefa> tarefas) {
            var enumerable = tarefas.ToList();
            foreach (var t in enumerable) {
                t.HorasEstudadas = 0;
            }
            _context.Tarefas.UpdateRange(enumerable);
            _context.SaveChanges();
        }
        public void ReiniciarHorasEstudadas(Tarefa tarefa) {
            tarefa.HorasEstudadas = 0;
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
        }
    }
}