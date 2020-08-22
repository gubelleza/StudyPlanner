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
        
        public double Prioridade { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public double HorasEstudadas { get; set; }

        public double MetaHoras { get; set; } = 0;

        public DateTime CriadaEm { get; set; }
        
        [NotMapped]
        public string FHorasEstudadas 
            => TimeSpan.FromHours(HorasEstudadas).ToString(@"hh\:mm\:ss");
                
        [NotMapped]
        public string FHorasEstudadasPonderadas
            => TimeSpan.FromHours(HorasEstudadasPonderadas).ToString(@"hh\:mm\:ss");
                
        [NotMapped]
        public string FMetaHoras
            => TimeSpan.FromHours(MetaHoras).ToString(@"hh\:mm\:ss");
        [NotMapped]
        public double HorasEstudadasPonderadas { get; set; }

        
        public override string ToString() {
            return $"Tarefa(ID: {TarefaID} Nome: {Nome})";
        }
    }
}