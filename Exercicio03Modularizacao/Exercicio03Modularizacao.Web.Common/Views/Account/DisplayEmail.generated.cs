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
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/DisplayEmail.cshtml")]
    public partial class _Views_Account_DisplayEmail_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Account_DisplayEmail_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\DisplayEmail.cshtml"
  
    ViewBag.Title = "DEMO purpose Email Link";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>");

            
            #line 4 "..\..\Views\Account\DisplayEmail.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h2>\r\n<p");

WriteLiteral(" class=\"text-info\"");

WriteLiteral(">\r\n    Please check your email and confirm your email address.\r\n</p>\r\n<p");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">\r\n    For DEMO only: You can click this link to confirm the email: <a");

WriteAttribute("href", Tuple.Create(" href=\"", 263), Tuple.Create("\"", 283)
            
            #line 9 "..\..\Views\Account\DisplayEmail.cshtml"
, Tuple.Create(Tuple.Create("", 270), Tuple.Create<System.Object, System.Int32>(ViewBag.Link
            
            #line default
            #line hidden
, 270), false)
);

WriteLiteral(">link</a>\r\n    Please change this code to register an email service in IdentityCo" +
"nfig to send an email.\r\n</p>\r\n");

        }
    }
}
#pragma warning restore 1591