using Microsoft.AspNetCore.Mvc;

namespace AgendaEstudos.Controllers {
    public class HomeController : Controller {
        
        [HttpGet]
        public ViewResult Index() {
            return View();
        }
    }
}