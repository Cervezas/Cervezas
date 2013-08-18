using System.Web.Mvc;

namespace Cervezas.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }
    }
}