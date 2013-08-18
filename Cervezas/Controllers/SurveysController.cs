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
    }
}