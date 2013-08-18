﻿// <auto-generated />
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

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC
{
    public static Cervezas.Controllers.HomeController Home = new Cervezas.Controllers.T4MVC_HomeController();
    public static Cervezas.Controllers.SitesController Sites = new Cervezas.Controllers.T4MVC_SitesController();
    public static Cervezas.Controllers.SurveysController Surveys = new Cervezas.Controllers.T4MVC_SurveysController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
		this.RouteValueDictionary.Remove("Area");
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_1_9_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.9.1.intellisense.min.js") ? Url("jquery-1.9.1.intellisense.min.js") : Url("jquery-1.9.1.intellisense.js");
        public static readonly string jquery_1_9_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.9.1.min.js") ? Url("jquery-1.9.1.min.js") : Url("jquery-1.9.1.js");
        public static readonly string jquery_1_9_1_min_js = Url("jquery-1.9.1.min.js");
        public static readonly string jquery_1_9_1_min_map = Url("jquery-1.9.1.min.map");
        public static readonly string less_min_js = Url("less.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class images {
            private const string URLPATH = "~/Content/images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string glyphicons_halflings_white_png = Url("glyphicons-halflings-white.png");
            public static readonly string glyphicons_halflings_png = Url("glyphicons-halflings.png");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class less {
            private const string URLPATH = "~/Content/less";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string accordion_less = Url("accordion.less");
            public static readonly string alerts_less = Url("alerts.less");
            public static readonly string bootstrap_less = Url("bootstrap.less");
            public static readonly string breadcrumbs_less = Url("breadcrumbs.less");
            public static readonly string button_groups_less = Url("button-groups.less");
            public static readonly string buttons_less = Url("buttons.less");
            public static readonly string carousel_less = Url("carousel.less");
            public static readonly string close_less = Url("close.less");
            public static readonly string code_less = Url("code.less");
            public static readonly string component_animations_less = Url("component-animations.less");
            public static readonly string dropdowns_less = Url("dropdowns.less");
            public static readonly string forms_less = Url("forms.less");
            public static readonly string grid_less = Url("grid.less");
            public static readonly string hero_unit_less = Url("hero-unit.less");
            public static readonly string labels_badges_less = Url("labels-badges.less");
            public static readonly string layouts_less = Url("layouts.less");
            public static readonly string media_less = Url("media.less");
            public static readonly string mixins_less = Url("mixins.less");
            public static readonly string modals_less = Url("modals.less");
            public static readonly string navbar_less = Url("navbar.less");
            public static readonly string navs_less = Url("navs.less");
            public static readonly string pager_less = Url("pager.less");
            public static readonly string pagination_less = Url("pagination.less");
            public static readonly string popovers_less = Url("popovers.less");
            public static readonly string progress_bars_less = Url("progress-bars.less");
            public static readonly string reset_less = Url("reset.less");
            public static readonly string responsive_1200px_min_less = Url("responsive-1200px-min.less");
            public static readonly string responsive_767px_max_less = Url("responsive-767px-max.less");
            public static readonly string responsive_768px_979px_less = Url("responsive-768px-979px.less");
            public static readonly string responsive_navbar_less = Url("responsive-navbar.less");
            public static readonly string responsive_utilities_less = Url("responsive-utilities.less");
            public static readonly string responsive_less = Url("responsive.less");
            public static readonly string scaffolding_less = Url("scaffolding.less");
            public static readonly string site_less = Url("site.less");
            public static readonly string site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/site.min.css") ? Url("site.min.css") : Url("site.css");
                 
            public static readonly string site_min_css = Url("site.min.css");
            public static readonly string sprites_less = Url("sprites.less");
            public static readonly string tables_less = Url("tables.less");
            public static readonly string thumbnails_less = Url("thumbnails.less");
            public static readonly string tooltip_less = Url("tooltip.less");
            public static readonly string type_less = Url("type.less");
            public static readonly string utilities_less = Url("utilities.less");
            public static readonly string variables_less = Url("variables.less");
            public static readonly string wells_less = Url("wells.less");
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


