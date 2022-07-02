using System.Web.Mvc;

namespace temagiydirme2.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult hakkimizda()
        {
            return View();
        }
        public ActionResult iletisim()
        {
            return View();
        }
        public ActionResult AdminG()
        {
            return View();
        }
    }
}