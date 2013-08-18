using System;
using System.Linq;
using System.Web.Mvc;
using AttributeRouting;
using AttributeRouting.Web.Mvc;
using Cervezas.Models;

namespace Cervezas.Controllers
{
    [RoutePrefix("sites/{siteId:int}/surveys/{surveyId:int}")]
    public partial class QuestionsController : Controller
    {
        private readonly Db _db;

        public QuestionsController(Db db)
        {
            _db = db;
        }

        [Route("questions")]
        public virtual ActionResult Index(int siteId, int surveyId)
        {
            var questions = _db.Questions.Where(o => o.SurveyId == surveyId && o.Survey.SiteId == siteId).ToList();
            return PartialView(questions);
        }

        [Route("questions/add")]
        [HttpGet]
        public virtual ActionResult Add(int siteId, int surveyId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public virtual ActionResult Add(int siteId, int surveyId, Question question)
        {
            throw new NotImplementedException();
        }
    }
}
