using System.Collections.Generic;
using System.Linq;
using AgendaEstudos.Models;
using AgendaEstudos.Models.Repository;

namespace AgendaEstudos.Services {
    public interface IStatsService{
        
        public void CalcularHorasPonderadas();
        
        public IEnumerable<Tarefa> Tarefas { get; set; }

        public double HorasTotais { get; }
        
        public double TotalFatorPrioridade { get; }

        public void AtribuirMetasProporcionais(double meta);

        public ITarefaRepository RepoTarefas { get; }

        public double MetaGeral { get; }

        public double CalcularMeta();

    }
}