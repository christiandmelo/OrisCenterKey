using OrisCenter.Key.ViewModels;
using System.Web.Mvc;

namespace OrisCenter.Key.Controllers
{
    public class TopicoController : Controller
    {
        [Authorize]
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Criar(TopicoCriarViewModel modelo)
        {
            return View();
        }
    }
}