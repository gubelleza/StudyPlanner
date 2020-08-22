using System;
using System.Collections.Generic;
using AgendaEstudos.Models;
using System.Linq;
using AgendaEstudos.Models.Repository;

namespace AgendaEstudos.Services {
    public class StatsService : IStatsService {

        private readonly ITarefaRepository _repository;

        public ITarefaRepository RepoTarefas => _repository;
        
        public IEnumerable<Tarefa> Tarefas { get; set; }

        public double HorasTotais
            => Tarefas.Sum(t => t.HorasEstudadas);
        
        public double TotalFatorPrioridade 
            => Tarefas.Sum(t => t.Prioridade);

        public double MetaGeral => Tarefas.Sum(t => t.MetaHoras);

        public StatsService(ITarefaRepository repo) {
            _repository = repo;
            Tarefas = _repository.ListarTarefas();
        }

        public double CalcularMeta() {
            double sum = 0;
            foreach (var t in Tarefas) {
                Console.WriteLine("Somand: " + t.MetaHoras);
                sum += t.MetaHoras;
            }
            Console.WriteLine("Resultado Soma: " + sum);
            return sum;
        }
        
        public void CalcularHorasPonderadas() {
            double unidadeComumHoras = HorasTotais / TotalFatorPrioridade;
            foreach (Tarefa t in Tarefas) {
                t.HorasEstudadasPonderadas = t.Prioridade * unidadeComumHoras;
            }
        }

        public void AtribuirMetasProporcionais(double meta) {
            double unidadeComumHoras = meta / TotalFatorPrioridade;

            foreach (Tarefa t in Tarefas) {
                t.MetaHoras = t.Prioridade * unidadeComumHoras;
                Console.WriteLine("Meta: " + t.MetaHoras);
            }
        }
        
        public static int ChecarViolacaoPrioridade(Tarefa t) {
            var poucoEstudo = t.HorasEstudadas < (t.HorasEstudadasPonderadas * 0.8);
            var muitoEstudo = t.HorasEstudadas > (t.HorasEstudadasPonderadas * 1.20);
            
            if (t.Prioridade <= Prioridades.Normal.Value && muitoEstudo) {
                return 1;
            } 
            if (t.Prioridade > Prioridades.Normal.Value && poucoEstudo) {
                return -1;
            }
            return 0;
        }

        public static string StrPorcentagem(double num, double denom) {
            if (Math.Round(denom).Equals(0)) {
                return "0,00%";
            }
            return $"{(num / denom) * 100:0.00}%";
        }
        
        public static string CssViolacaoPrioridade(Tarefa t) {
            int grauViolacao = ChecarViolacaoPrioridade(t);
            return grauViolacao != 0 ? "text-danger" : "";
        }
        
        public static string IconViolacaoPrioridade(Tarefa t) {
            int grauViolacao = ChecarViolacaoPrioridade(t);
            return grauViolacao switch {
                1 => "fa-angle-double-up",
                -1 => "fa-angle-double-down",
                _ => ""
            };
        }
    }
}