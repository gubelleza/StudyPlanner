using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable
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

        public void UpdateUnidade(Tarefa inputTarefa) {
            using (_context) {
                Tarefa? tarefa = _context.Tarefas
                    .FirstOrDefault(t => t.TarefaID == inputTarefa.TarefaID);
                if (tarefa == null) return;
                
                tarefa.Unidade = inputTarefa.Unidade;
                _context.SaveChanges();
            }
        }
        
        public int UpdateNonDefaultFields(Tarefa inputTarefa) {
            int updated = 0;
            using (_context) {
                Tarefa? tarefa = _context.Tarefas
                    .FirstOrDefault(t => t.TarefaID == inputTarefa.TarefaID);
                if (tarefa == null) return 0;

                if (FieldHasUpdatedTo(tarefa.Bibligrafia, inputTarefa.Bibligrafia)) {
                    tarefa.Bibligrafia = inputTarefa.Bibligrafia;
                    Console.WriteLine("BBT " + tarefa.Bibligrafia);
                    updated++;
                }
                if (FieldHasUpdatedTo(tarefa.Unidade, inputTarefa.Unidade)) {
                    tarefa.Unidade = inputTarefa.Unidade;
                    Console.WriteLine("Uni " + tarefa.Unidade);
                    updated++;
                }
                if (FieldHasUpdatedTo(tarefa.Descricao,inputTarefa.Descricao) ) {
                    tarefa.Descricao = inputTarefa.Descricao;
                    Console.WriteLine("Descricao" + tarefa.Descricao);
                    updated++;
                }
                if (FieldHasUpdatedTo(tarefa.Prioridade,inputTarefa.Prioridade) ) {
                    tarefa.Prioridade = inputTarefa.Prioridade;
                    Console.WriteLine("Prioridade" + tarefa.Prioridade);
                    updated++;
                }
                if (FieldHasUpdatedTo(tarefa.HorasEstudadas,inputTarefa.HorasEstudadas) ) {
                    tarefa.HorasEstudadas = inputTarefa.HorasEstudadas;
                    Console.WriteLine("HorasEstudadas " + tarefa.HorasEstudadas);
                    updated++;
                }
                if (FieldHasUpdatedTo(tarefa.MetaHoras,inputTarefa.MetaHoras) ) {
                    tarefa.MetaHoras = inputTarefa.MetaHoras;
                    Console.WriteLine("MetaHoras " + tarefa.MetaHoras);
                    updated++;
                }
                if (updated == 0) return 0;
                
                Console.WriteLine("Salvando " + updated);

                _context.SaveChanges(); 
                return updated;
            }
        }
        
        private bool FieldHasUpdatedTo(string formerState, string updatedState) {
            Console.WriteLine(formerState +  " " + updatedState);
            return updatedState != null && !formerState.Equals(updatedState);
        }
        private bool FieldHasUpdatedTo(double formerState, double updatedState) {
            return !Math.Round(updatedState, 1).Equals(default) && !formerState.Equals(updatedState);
        }
    }
}