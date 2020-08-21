using AgendaEstudos.Models;
using AgendaEstudos.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AgendaEstudos.Services;

namespace AgendaEstudos.Controllers {
    
    public class StatsController : Controller {

        private readonly IStatsService _service;

        public StatsController(IStatsService statsService) {
            _service = statsService;
        }

        // GET
        public IActionResult Index() {
            
            _service.CalcularHorasPonderadas();
            
            
            return View(new StatsViewModel {
                Tarefas = _service.RepoTarefas.ListarTarefas(),
                HorasTotais = _service.HorasTotais,
                MetaGeral = _service.CalcularMeta()
                });
        }
    }
}