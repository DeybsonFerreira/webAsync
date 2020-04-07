using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebAsync.Business;
using WebAsync.Models;

namespace WebAsync.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetPerson()
        {
            HomeBusiness homeBusiness = new HomeBusiness();
            List<Pessoa> person = homeBusiness.GetPerson();
            return Json(new { personResult = person }, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public async Task<ActionResult> GetPersonAsync()
        {
            HomeBusiness homeBusiness = new HomeBusiness();
            List<Pessoa> person = await homeBusiness.GetPersonAsync();
            return Json(new { personResult = person }, JsonRequestBehavior.AllowGet);
        }
    }
}

