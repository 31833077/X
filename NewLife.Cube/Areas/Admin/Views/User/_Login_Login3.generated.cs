﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    
    #line 1 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
    using NewLife.Cube.Web;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_Login_Login3.cshtml")]
    public partial class _Areas_Admin_Views_User__Login_Login3_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User__Login_Login3_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
  
    var set = NewLife.Cube.Setting.Current;
    var returnUrl = ViewBag.ReturnUrl as String;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar clearfix text-center\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"padding-top:30px;\"");

WriteLiteral(">\r\n        <span>\r\n            第三方登录：\r\n        </span>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 284), Tuple.Create("\"", 335)
            
            #line 11 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
, Tuple.Create(Tuple.Create("", 291), Tuple.Create<System.Object, System.Int32>(OAuthHelper.GetLoginUrl("Master",returnUrl)
            
            #line default
            #line hidden
, 291), false)
);

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-right\"");

WriteLiteral("></i>\r\n            主站\r\n        </a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 439), Tuple.Create("\"", 486)
            
            #line 15 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
, Tuple.Create(Tuple.Create("", 446), Tuple.Create<System.Object, System.Int32>(OAuthHelper.GetLoginUrl("QQ",returnUrl)
            
            #line default
            #line hidden
, 446), false)
);

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-right\"");

WriteLiteral("></i>\r\n            QQ\r\n        </a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 590), Tuple.Create("\"", 641)
            
            #line 19 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
, Tuple.Create(Tuple.Create("", 597), Tuple.Create<System.Object, System.Int32>(OAuthHelper.GetLoginUrl("Weixin",returnUrl)
            
            #line default
            #line hidden
, 597), false)
);

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-right\"");

WriteLiteral("></i>\r\n            微信\r\n        </a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 745), Tuple.Create("\"", 795)
            
            #line 23 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
, Tuple.Create(Tuple.Create("", 752), Tuple.Create<System.Object, System.Int32>(OAuthHelper.GetLoginUrl("Baidu",returnUrl)
            
            #line default
            #line hidden
, 752), false)
);

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-right\"");

WriteLiteral("></i>\r\n            百度\r\n        </a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 899), Tuple.Create("\"", 950)
            
            #line 27 "..\..\Areas\Admin\Views\User\_Login_Login3.cshtml"
, Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(OAuthHelper.GetLoginUrl("Github",returnUrl)
            
            #line default
            #line hidden
, 906), false)
);

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"glyphicon glyphicon-menu-right\"");

WriteLiteral("></i>\r\n            Github\r\n        </a>\r\n        ");

WriteLiteral("\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
