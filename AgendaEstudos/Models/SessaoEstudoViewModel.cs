using System;

namespace AgendaEstudos.Models {
    public class SessaoEstudoViewModel {
        
        public Tarefa Tarefa { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set; }
        public double DuracaoSessao 
            => HorarioFim.Subtract(HorarioInicio).TotalHours;

        public override string ToString() {
            return $"SessaoEstudo(Tarefa: {Tarefa}, " +
                   $"HorarioInicio: {HorarioInicio}, HorarioFim: {HorarioFim})";
        }
    }
}