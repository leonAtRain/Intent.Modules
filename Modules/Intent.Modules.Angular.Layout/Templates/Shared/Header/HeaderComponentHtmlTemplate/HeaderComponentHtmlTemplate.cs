// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Angular.Layout.Templates.Shared.Header.HeaderComponentHtmlTemplate
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.Html.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentHtmlTemplate\HeaderComponentHtmlTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class HeaderComponentHtmlTemplate : HtmlTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
  <a class=""navbar-brand"" routerLink=""/"">
    <img width=""30"" height=""30"" class=""d-inline-block align-top"" alt="" src=""data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAyNTAgMjUwIj4KICAgIDxwYXRoIGZpbGw9IiNERDAwMzEiIGQ9Ik0xMjUgMzBMMzEuOSA2My4ybDE0LjIgMTIzLjFMMTI1IDIzMGw3OC45LTQzLjcgMTQuMi0xMjMuMXoiIC8+CiAgICA8cGF0aCBmaWxsPSIjQzMwMDJGIiBkPSJNMTI1IDMwdjIyLjItLjFWMjMwbDc4LjktNDMuNyAxNC4yLTEyMy4xTDEyNSAzMHoiIC8+CiAgICA8cGF0aCAgZmlsbD0iI0ZGRkZGRiIgZD0iTTEyNSA1Mi4xTDY2LjggMTgyLjZoMjEuN2wxMS43LTI5LjJoNDkuNGwxMS43IDI5LjJIMTgzTDEyNSA1Mi4xem0xNyA4My4zaC0zNGwxNy00MC45IDE3IDQwLjl6IiAvPgogIDwvc3ZnPg=="">
    {{ title }}
  </a>
  <button class=""navbar-toggler"" type=""button"" (click)=""isCollapsed = !isCollapsed"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>
  <div class=""collapse navbar-collapse"" [collapse]=""isCollapsed"">
    <ul class=""navbar-nav"" intent-manage intent-id=""navbar"">
");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentHtmlTemplate\HeaderComponentHtmlTemplate.tt"
  foreach (var moduleRoute in _mainRoutes) { 
            
            #line default
            #line hidden
            this.Write("      <li class=\"nav-item active\" intent-manage=\"");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentHtmlTemplate\HeaderComponentHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(moduleRoute.Route));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <a class=\"nav-link\" routerLink=\"/");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentHtmlTemplate\HeaderComponentHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(moduleRoute.Route));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentHtmlTemplate\HeaderComponentHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(moduleRoute.ModuleName));
            
            #line default
            #line hidden
            this.Write("</a>\r\n      </li>\r\n");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Angular.Layout\Templates\Shared\Header\HeaderComponentHtmlTemplate\HeaderComponentHtmlTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("    </ul>\r\n  </div>\r\n</nav>\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
