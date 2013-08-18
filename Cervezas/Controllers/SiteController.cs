using System.Linq;
using System.Web.Mvc;
using Cervezas.Models;

namespace Cervezas.Controllers
{
    public partial class SiteController : Controller
    {
        private readonly Db _db;

        public SiteController(Db db)
        {
            _db = db;
        }

        public virtual ActionResult Index()
        {
            var sites = _db.Sites.ToList();
            return View(sites);
        }
    }
}
