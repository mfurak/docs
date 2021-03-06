﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static Raven.Documentation.Web.Controllers.ArticlesController Articles = new Raven.Documentation.Web.Controllers.T4MVC_ArticlesController();
    public static Raven.Documentation.Web.Controllers.AttachmentsController Attachments = new Raven.Documentation.Web.Controllers.T4MVC_AttachmentsController();
    public static Raven.Documentation.Web.Controllers.DocsController Docs = new Raven.Documentation.Web.Controllers.T4MVC_DocsController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

#pragma warning disable 0436
namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}
#pragma warning restore 0436

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
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
        public const string UrlPath = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        public static readonly string jquery_1_8_0_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-1.8.0.intellisense.min.js") ? Url("jquery-1.8.0.intellisense.min.js") : Url("jquery-1.8.0.intellisense.js");
        public static readonly string jquery_1_8_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-1.8.0.min.js") ? Url("jquery-1.8.0.min.js") : Url("jquery-1.8.0.js");
        public static readonly string jquery_1_8_0_min_js = Url("jquery-1.8.0.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string prism_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/prism.min.js") ? Url("prism.min.js") : Url("prism.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        public const string UrlPath = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string font_awesome_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/font-awesome.min.css") ? Url("font-awesome.min.css") : Url("font-awesome.css");
        public static readonly string font_awesome_min_css = Url("font-awesome.min.css");
        public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
        public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
        public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
        public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
        public static readonly string glyphicons_halflings_regular_woff2 = Url("glyphicons-halflings-regular.woff2");
        public static readonly string icomoon_eot = Url("icomoon.eot");
        public static readonly string icomoon_svg = Url("icomoon.svg");
        public static readonly string icomoon_ttf = Url("icomoon.ttf");
        public static readonly string icomoon_woff = Url("icomoon.woff");
        public static readonly string prism_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/prism.min.css") ? Url("prism.min.css") : Url("prism.css");
        public static readonly string Site_less = Url("Site.less");
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
        public static readonly string Site_css_map = Url("Site.css.map");
        public static readonly string Site_min_css = Url("Site.min.css");
        public static readonly string socicon_webfont_eot = Url("socicon-webfont.eot");
        public static readonly string socicon_webfont_svg = Url("socicon-webfont.svg");
        public static readonly string socicon_webfont_ttf = Url("socicon-webfont.ttf");
        public static readonly string socicon_webfont_woff = Url("socicon-webfont.woff");
        public static readonly string socicon_webfont_woff2 = Url("socicon-webfont.woff2");
        public static readonly string styles_less = Url("styles.less");
        public static readonly string styles_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/styles.min.css") ? Url("styles.min.css") : Url("styles.css");
        public static readonly string styles_min_css = Url("styles.min.css");
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static class Assets
            {
                public static readonly string _references_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/_references.js"); 
                public static readonly string jquery_1_8_0_intellisense_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-1.8.0.intellisense.js"); 
                public static readonly string jquery_1_8_0_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-1.8.0.js"); 
                public static readonly string jquery_1_8_0_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-1.8.0.min.js"); 
                public static readonly string jquery_validate_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.js"); 
                public static readonly string jquery_validate_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.min.js"); 
                public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.unobtrusive.js"); 
                public static readonly string jquery_validate_unobtrusive_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.unobtrusive.min.js"); 
                public static readonly string prism_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/prism.js"); 
            }
        }
        public static partial class Content 
        {
            public static class Assets
            {
                public static readonly string font_awesome_css = T4MVCHelpers.ProcessAssetPath("~/Content/font-awesome.css");
                public static readonly string font_awesome_min_css = T4MVCHelpers.ProcessAssetPath("~/Content/font-awesome.min.css");
                public static readonly string prism_css = T4MVCHelpers.ProcessAssetPath("~/Content/prism.css");
            }
        }
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

    private static string ProcessAssetPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and should retain this prefix
        return virtualPath;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
    public static Func<string, string> ProcessAssetPath = ProcessAssetPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


