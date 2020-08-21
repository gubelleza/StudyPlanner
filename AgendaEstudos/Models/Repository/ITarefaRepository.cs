using System.Collections.Generic;
using AgendaEstudos.Models;

namespace AgendaEstudos.Models.Repository {
    
    public interface ITarefaRepository {
        public void CreateTarefa(Tarefa tarefa);
        public IEnumerable<Tarefa> ListarTarefas();
        public Tarefa GetById(long id);
        public void Atualizar(Tarefa tarefa);
        public void DeletarTarefa(Tarefa tarefa);
    }
}