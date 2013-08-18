using System.Linq;
using System.Web.Mvc;
using AttributeRouting;
using AttributeRouting.Web.Mvc;
using Cervezas.Models;

namespace Cervezas.Controllers
{
    [RoutePrefix("sites/{siteId:int}")]
    public partial class SurveysController : Controller
    {
        private readonly Db _db;

        public SurveysController(Db db)
        {
            _db = db;
        }

        [Route("surveys")]
        public virtual ActionResult Index(int siteId)
        {
            var surveys = _db.Surveys.Where(o => o.SiteId == siteId).ToList();
            return PartialView(surveys);
        }

        [Route("surveys/add")]
        [HttpGet]
        public virtual ActionResult Add(int siteId)
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Add(int siteId, Survey survey)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var site = _db.Sites.Find(siteId);
            site.Surveys.Add(survey);
            _db.SaveChanges();

            return RedirectToAction(MVC.Sites.Show(siteId));
        }
    }
}