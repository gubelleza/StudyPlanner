using System;
using System.Collections.Generic;

namespace AgendaEstudos.Models {
    public class StatsViewModel {
        
        public IEnumerable<Tarefa> Tarefas { get; set; }
        public double HorasTotais { get; set; }
        public double MetaGeral { get; set; }        
        
        public string FHorasTotais
            => TimeSpan.FromHours(HorasTotais).ToString(@"hh\:mm\:ss");
        
        public string FMetaGeral => 
            $"{(int) MetaGeral}:{60 * (MetaGeral - (int)MetaGeral):00}";
    }
}