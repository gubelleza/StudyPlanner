using AgendaEstudos.Models;
using AgendaEstudos.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgendaEstudos.Controllers {
    
    public class StatsController : Controller {
        
        private readonly ITarefaRepository _repository;

        public StatsController(ITarefaRepository repo) {
            _repository = repo;
        }

        
        // GET
        public IActionResult Index() {
            return View(new StatsViewModel {
                Tarefas = _repository.ListarTarefas(),
                HorasTotais = _repository
                    .ListarTarefas()
                    .Sum(tarefa => tarefa.HorasEstudadas),
                HorasTotaisFator = _repository
                    .ListarTarefas()
                    .Sum(tarefa => tarefa.HorasEstudadasCorrigidas())
            });
        }
    }
}