using System;
using System.Linq;
using AgendaEstudos.Models.Repository;
using AgendaEstudos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaEstudos.Controllers {
    public class TarefasController : Controller {

        private readonly ITarefaRepository _repository;

        public TarefasController(ITarefaRepository repo) {
            _repository = repo;
        }
        
        // ----- [Listar Tarefas]
        [HttpGet]
        public ViewResult Listar()
            => View(_repository.ListarTarefas()
                .OrderBy(t => t.HorasEstudadas/t.MetaHoras)
                .ThenByDescending(t => t.Prioridade)
            );
        
        // ----- [Criar Tarefas]
        [HttpGet]
        public ViewResult CriarTarefa() => View(new Tarefa());
        
        [HttpPost]
        public IActionResult CriarTarefa(Tarefa tarefa) {
            
            if (ModelState.IsValid) {
                Console.WriteLine("Criando tarefa:" + tarefa);
                _repository.CreateTarefa(tarefa);
                return Redirect("/");
            }

            return RedirectToAction("CriarTarefa", tarefa);
        }
        
        // ----- [Atualizar Tarefa]
        [HttpGet]
        public ViewResult Atualizar(long id)
            => View(_repository.GetById(id));
        
        [HttpPost]
        public IActionResult Atualizar(Tarefa tarefa) {
            _repository.Atualizar(tarefa);
            return RedirectToAction("Listar", tarefa);
        }
        
        // ----- [Deletar Tarefa]
        [HttpPost]
        public IActionResult Deletar(Tarefa tarefa) {
            Console.WriteLine("Delete controller: " + tarefa);
            _repository.DeletarTarefa(tarefa);

            return RedirectToAction("Listar");
        }
    }
}