using System.Collections.Generic;
using AgendaEstudos.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaEstudos.Models.Repository {
    
    public interface ITarefaRepository {
        public void CreateTarefa(Tarefa tarefa);
        public IEnumerable<Tarefa> ListarTarefas();
        public Tarefa GetById(long id);
        public void Atualizar(Tarefa tarefa);
        public void Atualizar(IEnumerable<Tarefa> tarefas);
        public void DeletarTarefa(Tarefa tarefa);
        public void ReiniciarHorasEstudadas(IEnumerable<Tarefa> tarefas);
        public void DeletarTarefas(IEnumerable<Tarefa> tarefas);
    }
}