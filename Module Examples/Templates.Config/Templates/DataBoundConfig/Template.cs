﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Templates.Config.Templates.DataBoundConfig
{
    using Intent.MetaModel.Domain;
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\IntentArchitect\Module Examples\Templates.Config\Templates\DataBoundConfig\Template.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class Template : Intent.SoftwareFactory.Templates.IntentProjectItemTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            this.Write("\r\nTemplate DataBoundConfig\r\nVariable 1 : ");
            
            #line 13 "C:\Dev\IntentArchitect\Module Examples\Templates.Config\Templates\DataBoundConfig\Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FileMetaData.CustomMetaData["Variable1"]));
            
            #line default
            #line hidden
            this.Write("\r\nVariable 2 : ");
            
            #line 14 "C:\Dev\IntentArchitect\Module Examples\Templates.Config\Templates\DataBoundConfig\Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FileMetaData.CustomMetaData["Variable2"]));
            
            #line default
            #line hidden
            this.Write("\r\nVariable 3 : ");
            
            #line 15 "C:\Dev\IntentArchitect\Module Examples\Templates.Config\Templates\DataBoundConfig\Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FileMetaData.CustomMetaData["Variable3"]));
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
