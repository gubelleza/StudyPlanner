using System;
using System.Collections.Generic;

namespace AgendaEstudos.Models {
    public class StatsViewModel {
        
        public IEnumerable<Tarefa> Tarefas { get; set; }
        public double HorasTotais { get; set; }
        public double MetaGeral { get; set; }        

        public string TempoDecorrido(double periodo) {
            int minutos = (int)Math.Round(60 * (periodo - (int)periodo), 0);
            int minutosF = minutos == 60 ? 0 : minutos;
            return $"{(int) periodo}:{minutosF:00}";
        }
    }
}