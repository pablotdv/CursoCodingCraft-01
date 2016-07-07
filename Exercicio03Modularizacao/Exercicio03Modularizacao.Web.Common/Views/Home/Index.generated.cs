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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"jumbotron\"");

WriteLiteral(">\r\n    <h1>ASP.NET Identity - mesma Index</h1>\r\n    <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">ASP.NET Identity is the membership system for ASP.NET apps. Following are the fe" +
"atures of ASP.NET Identity in this sample application.</p>\r\n    <p><a");

WriteLiteral(" href=\"http://www.asp.net/identity\"");

WriteLiteral(" class=\"btn btn-primary btn-large\"");

WriteLiteral(">Learn more &raquo;</a></p>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Initialize ASP.NET Identity</dt>
            <dd>
                You can initialize ASP.NET Identity when the application starts. Since ASP.NET Identity is Entity Framework based in this sample,
                you can create DatabaseInitializer which is configured to get called each time the app starts.
                <strong>Please look in App_Start\IdentityConfig.cs</strong>
                This code shows the following
                <ul>
                    <li>When should the Initializer run and when should the database be created</li>
                    <li>Create Admin user</li>
                    <li>Create Admin role</li>
                    <li>Add Admin user to Admin role</li>
                </ul>
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n        <dl>\r\n            <dt>Add profile data for the user</dt>\r\n            " +
"<dd>\r\n                <a");

WriteLiteral(" href=\"http://blogs.msdn.com/b/webdev/archive/2013/10/16/customizing-profile-info" +
"rmation-in-asp-net-identity-in-vs-2013-templates.aspx\"");

WriteLiteral(@">Please follow this tutorial.</a>

                <ul>
                    <li>Add profile information in the Users Table</li>
                    <li>Look in Models\IdentityModels.cs for examples</li>
                </ul>
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Validation</dt>
            <dd>
                When you create a User using a username or password, the Identity system performs validation on the username and password, and the passwords are hashed before they are
                stored in the database. You can customize the validation by changing some of the properties of the validators such as Turn alphanumeric on/off, set minimum password length
                or you can write your own custom validators and register them with the UserManager.
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n        <dl>\r\n            <dt>Register a user and login</dt>\r\n            <dd>" +
"\r\n                Click ");

            
            #line 56 "..\..\Views\Home\Index.cshtml"
                 Write(Html.ActionLink("Register", "Register", "Account"));

            
            #line default
            #line hidden
WriteLiteral(" and see the code in AccountController.cs and Register Action.\r\n                C" +
"lick ");

            
            #line 57 "..\..\Views\Home\Index.cshtml"
                 Write(Html.ActionLink("Log in", "Login", "Account"));

            
            #line default
            #line hidden
WriteLiteral(" and see the code in AccountController.cs and Login Action.\r\n            </dd>\r\n " +
"       </dl>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Social Logins</dt>
            <dd>
                You can the support so that users can login using their Facebook, Google, Twitter, Microsoft Account and more.
            </dd>
            <dd>
                <ul>
                    <li>
                        <a");

WriteLiteral(" href=\"http://www.windowsazure.com/en-us/documentation/articles/web-sites-dotnet-" +
"deploy-aspnet-mvc-app-membership-oauth-sql-database/\"");

WriteLiteral(">Add Social Logins</a>\r\n                    </li>\r\n                    <li>\r\n    " +
"                    <a");

WriteLiteral(" href=\"http://blogs.msdn.com/b/webdev/archive/2013/10/16/get-more-information-fro" +
"m-social-providers-used-in-the-vs-2013-project-templates.aspx\"");

WriteLiteral(">Get more data about the user when they login suing Facebook</a>\r\n               " +
"     </li>\r\n                </ul>\r\n            </dd>\r\n        </dl>\r\n    </div>\r" +
"\n    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Basic User Management</dt>
            <dd>
                Do Create, Update, List and Delete Users.
                Assign a Role to a User.
                Only Users In Role Admin can access this page. This uses the [Authorize(Roles = ""Admin"")] on the UserAdmin controller.
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Basic Role Management</dt>
            <dd>
                Do Create, Update, List and Delete Roles.
                Only Users In Role Admin can access this page. This authorization is doen by using the [Authorize(Roles = ""Admin"")] on the RolesAdmin controller.
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n        <dl>\r\n            <dt>Account Confirmation</dt>\r\n            <dd>\r\n   " +
"             When you register a new account, you will be sent an email confirma" +
"tion.\r\n                You can use an email service such as <a");

WriteLiteral(" href=\"http://www.windowsazure.com/en-us/documentation/articles/sendgrid-dotnet-h" +
"ow-to-send-email/\"");

WriteLiteral(@">SendGrid</a> which integrate nicely with Windows Azure and requires no configuration or
                set up an SMTP server to send email.
                You can send email using the EmailService which is registered in App_Start\IdentityConfig.cs
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Two-Factor Authentication</dt>
            <dd>
                This sample shows how you can use Two-Factor authentication. This sample has a SMS and email service registered where you can send SMS or email for sending the security code.
                You can add more two-factor authentication factors such as QR codes and plug them into ASP.NET Identity.
                <ul>
                    <li>
                        You can use a SMS using <a");

WriteLiteral(" href=\"https://www.twilio.com/\"");

WriteLiteral(">Twilio</a> or use any means of sending SMS. Please <a");

WriteLiteral(" href=\"https://www.twilio.com/docs/quickstart/csharp/sms/sending-via-rest\"");

WriteLiteral(@">read</a> for more details on using Twilio.
                        You can send SMS using the SmsService which is registered in App_Start\IdentityConfig.cs
                    </li>
                    <li>
                        You can use an email service such as <a");

WriteLiteral(" href=\"http://www.windowsazure.com/en-us/documentation/articles/sendgrid-dotnet-h" +
"ow-to-send-email/\"");

WriteLiteral(">SendGrid</a> or\r\n                        set up an SMTP server to send email.\r\n " +
"                       You can send email using the EmailService which is regist" +
"ered in App_Start\\IdentityConfig.cs\r\n                    </li>\r\n\r\n              " +
"      <li>\r\n                        When you login, you can add a phone number b" +
"y clicking the Manage page.\r\n                    </li>\r\n                    <li>" +
"\r\n                        Once you add a phone number and have the Phone service" +
" hooked to send a SMS, you will get a code through SMS to confirm your phone num" +
"ber.\r\n                    </li>\r\n                    <li>\r\n                     " +
"   In the Manage page, you can turn on Two-Factor authentication.\r\n             " +
"       </li>\r\n                    <li>\r\n                        When you logout " +
"and login, after you enter the username and password, you will get an option of " +
"how to get the security code to use for two-factor authentication.\r\n            " +
"        </li>\r\n                    <li>\r\n                        You can copy th" +
"e code from your SMS or email and enter in the form to login.\r\n                 " +
"   </li>\r\n                    <li>\r\n                        The sample also show" +
"s how to protect against Brute force attacks against two-factor codes. When you " +
"enter a code incorrectly for 5 times then you will be\r\n                        l" +
"ockedout for 5 min before you can enter a new code. These settings can be config" +
"ured in App_Start\\IdentityConfig.cs by setting  DefaultAccountLockoutTimeSpan an" +
"d MaxFailedAccessAttemptsBeforeLockout on the UserManager.\r\n                    " +
"</li>\r\n                    <li>\r\n                        If the machine you are " +
"browsing this website is your own machine, you can choose to check the \"Remember" +
" Me\" option after you enter the code.\r\n                        This option will " +
"remember you forever on this machine and will not ask you for the two-factor aut" +
"hentication, the next time when you login to the website.\r\n                     " +
"   You can change your \"Remember Me\" settings for two-factor authentication in t" +
"he Manage page.\r\n                    </li>\r\n                </ul>\r\n            <" +
"/dd>\r\n        </dl>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Account Lockout</dt>
            <dd>
                Provide a way to Lockout out the user if the user enters their password or two-factor codes incorrectly.
                The number of invalid attempts and the timespan for the users are locked out can be configured.
                A developer can optionally turn off Account Lockout for certain user accounts should they need to.
            </dd>
            <ul>
                <li>Account LockOut settings can be configured in the UserManager in IdentityConfig.cs</li>
            </ul>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Security Token provider</dt>
            <dd>
                Support a way to regenerate the Security Token for the user in cases when the User changes there password or any other security related information such as removing an associated login(such as Facebook, Google, Microsoft Account etc).
                This is needed to ensure that any tokens generated with the old password are invalidated. In the sample project, if you change the users password then a new token is generated for the user and any previous tokens are invalidated.
                This feature provides an extra layer of security to your application since when you change your password, you will be logged out from everywhere (all other browsers) where you have logged into this application.
            </dd>
            <dd>
                <ul>
                    <li>The provider is registered when you add CookieAuthentication in StartupAuth to your application.</li>
                </ul>
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Password Reset</dt>
            <dd>
                Allows the user to reset their passwords if they have forgotten their password. In this sample users need to confirm their email before they can reset their passwords.
            </dd>
        </dl>
    </div>
    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(@">
        <dl>
            <dt>Custom Storage providers</dt>
            <dd>
                You can extend ASP.NET Identity to write your own custom storage provider for storing the ASP.NET Identity system and user data
                in a persistance system of your choice such as MondoDb, RavenDb, Azure Table Storage etc.
            </dd>
            <dd>
                <ul>
                    <li>
                        <a");

WriteLiteral(" href=\"http://www.asp.net/identity/overview/extensibility/overview-of-custom-stor" +
"age-providers-for-aspnet-identity\"");

WriteLiteral(">\r\n                            learn more on how to implement your own storage pr" +
"ovider\r\n                        </a>\r\n                    </li>\r\n               " +
" </ul>\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n        <dl>\r\n            <dt>Documentation</dt>\r\n            <dd>\r\n          " +
"      <ul>\r\n                    <li>\r\n                        Tutorials: <a");

WriteLiteral(" href=\"www.asp.net/identity\"");

WriteLiteral(">www.asp.net/identity</a>\r\n                    </li>\r\n                    <li>\r\n " +
"                       StackOverflow: <a");

WriteLiteral(" href=\"http://stackoverflow.com/questions/tagged/asp.net-identity\"");

WriteLiteral(">http://stackoverflow.com/questions/tagged/asp.net-identity</a>\r\n                " +
"    </li>\r\n                    <li>\r\n                        Twitter: #identity " +
"#aspnet\r\n                    </li>\r\n                    <li>\r\n                  " +
"      <a");

WriteLiteral(" href=\"http://curah.microsoft.com/55636/aspnet-identity\"");

WriteLiteral(">ASP.NET Identity on curah</a>\r\n                    </li>\r\n                    <l" +
"i>\r\n                        Have bugs or suggestions for ASP.NET Identity <a");

WriteLiteral(" href=\"http://aspnetidentity.codeplex.com/\"");

WriteLiteral(">http://aspnetidentity.codeplex.com/</a>\r\n                    </li>\r\n            " +
"    </ul>\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
