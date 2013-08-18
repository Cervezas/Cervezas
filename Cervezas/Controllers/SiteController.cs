using System.Linq;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;
using Cervezas.Models;

namespace Cervezas.Controllers
{
    public partial class SitesController : Controller
    {
        private readonly Db _db;

        public SitesController(Db db)
        {
            _db = db;
        }

        public virtual ActionResult Index()
        {
            var sites = _db.Sites.ToList();
            return View(sites);
        }

        [Route("sites/add")]
        [HttpGet]
        public virtual ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Add(Site site)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _db.Sites.Add(site);
            _db.SaveChanges();
            return RedirectToAction(MVC.Sites.Index());
        }

        [Route("sites/{siteId:int}")]
        public virtual ActionResult Show(int siteId)
        {
            var site = _db.Sites.Find(siteId);

            if (site == null)
            {
                return new HttpNotFoundResult();
            }

            return View(site);
        }
    }
}