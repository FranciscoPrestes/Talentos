using System.Linq;
using System.Web.Mvc;
using Talentos.Application.Interfaces;
using Talentos.MVC.Helpers;
using Talentos.MVC.ViewModels;

namespace Talentos.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandidatoAppService _candidatoAppService;

        public HomeController(ICandidatoAppService clienteApp)
        {
            _candidatoAppService = clienteApp;
        }

        public ActionResult Index()
        {
            return View(new CandidaturaViewModel());
        }


        [HttpPost]
        public ActionResult EnviarCandidatura(CandidaturaViewModel candidaturaView)
        {
            if (ModelState.IsValid)
            {
                var candidato = candidaturaView.ConvertToModel();


                //avalia e manda os emails
                _candidatoAppService.AvaliarCandidato(candidato);

                return new JsonResult
                {
                    Data = new
                    {
                        title = "Sucesso!",
                        text = "Cadastro efetuado com sucesso!.",
                        type = "success",
                        view = this.RenderPartialView("Index", new CandidaturaViewModel())
                    },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
               
            }

            return RedirectToAction("Index", candidaturaView);
        }
    }
}