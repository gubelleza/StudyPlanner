using System.Collections.Generic;

namespace AgendaEstudos.Models {
    public class StatsViewModel {
        
        public IEnumerable<Tarefa> Tarefas { get; set; }
        public double HorasTotais { get; set; }
        public double HorasTotaisFator { get; set; }
    }
}