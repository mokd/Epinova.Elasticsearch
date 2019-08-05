﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Epinova.ElasticSearch.Core.EPiServer.Extensions;
    using EPiServer;
    using EPiServer.Core;
    using EPiServer.Editor;
    using EPiServer.Framework.Web.Resources;
    using EPiServer.Security;
    using EPiServer.Shell.Navigation;
    using EPiServer.Shell.UI;
    using EPiServer.Shell.Web.Mvc.Html;
    using EPiServer.SpecializedProperties;
    using EPiServer.Web;
    using EPiServer.Web.Mvc.Html;
    using EPiServer.Web.Routing;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ElasticSearchAdmin/_ElasticSearch.cshtml")]
    public partial class _Views_ElasticSearchAdmin__ElasticSearch_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_ElasticSearchAdmin__ElasticSearch_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org" +
"/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html>\r\n<head>\r\n    <title>Episerver C" +
"MS - ");

                      Write(Html.TranslateWithPath("heading", "/epinovaelasticsearch/"));

WriteLiteral("</title>\r\n\r\n    <!-- Shell -->\r\n");

WriteLiteral("    ");

Write(Html.Raw(ClientResources.RenderResources("ShellCore")));

WriteLiteral("\r\n");

WriteLiteral("    ");

Write(Html.Raw(ClientResources.RenderResources("ShellWidgets")));

WriteLiteral("\r\n\r\n    <!-- LightTheme -->\r\n");

WriteLiteral("    ");

Write(Html.Raw(ClientResources.RenderResources("ShellCoreLightTheme")));

WriteLiteral("\r\n\r\n    <!-- Navigation -->\r\n");

WriteLiteral("    ");

Write(Html.Raw(ClientResources.RenderResources("Navigation")));

WriteLiteral("\r\n\r\n    <!-- Dojo Dashboard -->\r\n");

WriteLiteral("    ");

Write(Html.Raw(ClientResources.RenderResources("DojoDashboardCompatibility", new[] { ClientResourceType.Style })));

WriteLiteral("\r\n\r\n    <!-- Sleek theme -->\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 981), Tuple.Create("\"", 1078)
, Tuple.Create(Tuple.Create("", 988), Tuple.Create<System.Object, System.Int32>(EPiServer.Shell.Paths.ToShellClientResource("ClientResources/epi/themes/sleek/sleek.css")
, 988), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 1110), Tuple.Create("\"", 1210)
, Tuple.Create(Tuple.Create("", 1117), Tuple.Create<System.Object, System.Int32>(EPiServer.Shell.Paths.ToShellClientResource("ClientResources/epi/themes/sleek/document.css")
, 1117), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n");

WriteLiteral("    ");

Write(Html.Raw(DojoConfigurationHelper.ConfigureDojo(null,
        new DojoConfig
        {
            ParseOnLoad = ViewBag.DojoParseOnLoad ?? true,
            Async = true,
            IoPublish = true
        }, true)));

WriteLiteral("\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1478), Tuple.Create("\"", 1560)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(EPiServer.Shell.Paths.ToShellClientResource("ClientResources/dojo/dojo.js")
, 1484), false)
);

WriteLiteral("></script>\r\n\r\n    <script>\r\n        require([\"dojo/parser\"]);\r\n    </script>\r\n\r\n " +
"   <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1652), Tuple.Create("\"", 1741)
, Tuple.Create(Tuple.Create("", 1658), Tuple.Create<System.Object, System.Int32>(EPiServer.Shell.Paths.ToShellClientResource("ClientResources/dojox/grid/_Grid.js")
, 1658), false)
);

WriteLiteral("></script>\r\n\r\n    <style>\r\n        /* Override document.css */\r\n        html, bod" +
"y {\r\n            position: relative;\r\n        }\r\n\r\n        .indexInspector {\r\n  " +
"          display: flex;\r\n            flex-wrap: nowrap;\r\n        }\r\n\r\n         " +
"   .indexInspector .mainContent {\r\n                box-sizing: border-box;\r\n    " +
"            width: 70%;\r\n                padding-right: 5%;\r\n            }\r\n\r\n  " +
"          .indexInspector .sidebar {\r\n                width: 30%;\r\n            }" +
"\r\n\r\n                .indexInspector .sidebar ul {\r\n                    margin-le" +
"ft: .3em;\r\n                    margin-bottom: .5em;\r\n                }\r\n\r\n      " +
"      .indexInspector label {\r\n                text-transform: capitalize;\r\n    " +
"        }\r\n\r\n        pre {\r\n            white-space: pre-wrap; /* Since CSS 2.1 " +
"*/\r\n            white-space: -moz-pre-wrap; /* Mozilla, since 1999 */\r\n         " +
"   white-space: -pre-wrap; /* Opera 4-6 */\r\n            white-space: -o-pre-wrap" +
"; /* Opera 7 */\r\n            word-wrap: break-word; /* Internet Explorer 5.5+ */" +
"\r\n            border: none;\r\n        }\r\n\r\n        .accordion {\r\n            marg" +
"in-bottom: 15px;\r\n            background-color: #F0F0F0;\r\n            border: 1p" +
"x solid #CCC;\r\n            padding: 20px;\r\n        }\r\n\r\n            .accordion >" +
" h3 > button {\r\n                border: none;\r\n                background: none;" +
"\r\n                width: 100%;\r\n                padding: 0;\r\n                tex" +
"t-align: left;\r\n            }\r\n\r\n                .accordion > h3 > button[aria-e" +
"xpanded=\"true\"] {\r\n                    font-weight: bold;\r\n                }\r\n\r\n" +
"        .accordion-panel {\r\n            border-top: 1px solid #CCC;\r\n           " +
" margin-top: 10px;\r\n        }\r\n\r\n            .accordion-panel code {\r\n          " +
"      display: block;\r\n                border: none;\r\n                font-size:" +
" 70%;\r\n            }\r\n\r\n        .indexes {\r\n            padding: 0;\r\n        }\r\n" +
"    </style>\r\n\r\n");

WriteLiteral("    ");

Write(RenderSection("Styles", false));

WriteLiteral("\r\n</head>\r\n<body");

WriteLiteral(" class=\"Sleek\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

Write(Html.Raw(ViewBag.Menu));

WriteLiteral("\r\n    <div");

WriteLiteral(" id=\"epi-globalDocument\"");

WriteAttribute("class", Tuple.Create(" class=\"", 3808), Tuple.Create("\"", 3874)
, Tuple.Create(Tuple.Create("", 3816), Tuple.Create<System.Object, System.Int32>(ViewBag.ContainerClass ?? "epi-paddingHorizontal-small"
, 3816), false)
);

WriteLiteral(">\r\n        <div>\r\n");

WriteLiteral("            ");

       Write(RenderBody());

WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

WriteLiteral("    ");

Write(RenderSection("Scripts", false));

WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
