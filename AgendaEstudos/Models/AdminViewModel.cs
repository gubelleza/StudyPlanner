using System.Collections.Generic;

namespace AgendaEstudos.Models {
    public class AdminViewModel {
        public IEnumerable<Tarefa> Tarefas { get; set; }
        public double Meta { get; set; }
    }
}