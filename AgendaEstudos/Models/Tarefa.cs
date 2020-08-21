using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaEstudos.Models {
    public class Tarefa {
        
        public long TarefaID { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }
        
        public string Bibligrafia { get; set; }
        
        public string Unidade { get; set; }
        
        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }
        
        public int Prioridade { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public double HorasEstudadas { get; set; }

        public DateTime CriadaEm { get; set; }
        
        [NotMapped]
        public string FHorasEstudadas 
            => TimeSpan.FromHours(HorasEstudadas).ToString(@"hh\:mm\:ss");
        
        public override string ToString() {
            return $"Tarefa(ID: {TarefaID} Nome: {Nome})";
        }

        public double HorasEstudadasCorrigidas() {
            switch (Prioridade) {
                case -2:
                    return HorasEstudadas * 1.75;
                case -1:
                    return HorasEstudadas * 1.50;
                case 0:
                    return HorasEstudadas;
                case 1:
                    return HorasEstudadas * 0.75;
                case 2:
                    return HorasEstudadas * 0.60;
                default:
                    return HorasEstudadas;
            }
        }
    }
}