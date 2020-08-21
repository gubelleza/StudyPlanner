using System;
using AgendaEstudos.Models;
using AgendaEstudos.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AgendaEstudos.Controllers {
    public class SessaoEstudoController : Controller {

        private readonly ITarefaRepository _repository;

        public SessaoEstudoController(ITarefaRepository repo) {
            _repository = repo;
        }
        
        public ViewResult IniciarSessao(long id)
            => View("NovaSessao", 
                new SessaoEstudoViewModel {
                    Tarefa = _repository.GetById(id),
                    HorarioInicio = DateTime.Now
                });

        public IActionResult ConcluirSessao(SessaoEstudoViewModel sessaoEstudo) {
            sessaoEstudo.HorarioFim = DateTime.Now;
            
            Tarefa tarefa = _repository.GetById(sessaoEstudo.Tarefa.TarefaID);
            tarefa.HorasEstudadas += sessaoEstudo.DuracaoSessao;
            _repository.Atualizar(tarefa);
            
            return Redirect("/tarefas/listar");
        }
    }
}