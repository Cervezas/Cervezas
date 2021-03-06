// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Cervezas.Controllers
{
    public partial class SurveysController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SurveysController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Add()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Show()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Show);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SurveysController Actions { get { return MVC.Surveys; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Surveys";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Surveys";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Add = "Add";
            public readonly string Show = "Show";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Add = "Add";
            public const string Show = "Show";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string siteId = "siteId";
        }
        static readonly ActionParamsClass_Add s_params_Add = new ActionParamsClass_Add();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Add AddParams { get { return s_params_Add; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Add
        {
            public readonly string siteId = "siteId";
            public readonly string survey = "survey";
        }
        static readonly ActionParamsClass_Show s_params_Show = new ActionParamsClass_Show();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Show ShowParams { get { return s_params_Show; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Show
        {
            public readonly string siteId = "siteId";
            public readonly string surveyId = "surveyId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Add = "Add";
                public readonly string Index = "Index";
                public readonly string Show = "Show";
            }
            public readonly string Add = "~/Views/Surveys/Add.cshtml";
            public readonly string Index = "~/Views/Surveys/Index.cshtml";
            public readonly string Show = "~/Views/Surveys/Show.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SurveysController : Cervezas.Controllers.SurveysController
    {
        public T4MVC_SurveysController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int siteId);

        public override System.Web.Mvc.ActionResult Index(int siteId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "siteId", siteId);
            IndexOverride(callInfo, siteId);
            return callInfo;
        }

        partial void AddOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int siteId);

        public override System.Web.Mvc.ActionResult Add(int siteId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "siteId", siteId);
            AddOverride(callInfo, siteId);
            return callInfo;
        }

        partial void AddOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int siteId, Cervezas.Models.Survey survey);

        public override System.Web.Mvc.ActionResult Add(int siteId, Cervezas.Models.Survey survey)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "siteId", siteId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "survey", survey);
            AddOverride(callInfo, siteId, survey);
            return callInfo;
        }

        partial void ShowOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int siteId, int surveyId);

        public override System.Web.Mvc.ActionResult Show(int siteId, int surveyId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Show);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "siteId", siteId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "surveyId", surveyId);
            ShowOverride(callInfo, siteId, surveyId);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
