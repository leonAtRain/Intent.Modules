﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Typescript.Config.Templates.TypescriptDefinitelyTypedReference
{
    using Intent.Modules.Common.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Typescript.Config\Templates\TypescriptDefinitelyTypedReference\TypescriptDefinitelyTypedReferencesTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class TypescriptDefinitelyTypedReferencesTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Typescript.Config\Templates\TypescriptDefinitelyTypedReference\TypescriptDefinitelyTypedReferencesTemplate.tt"




            
            #line default
            #line hidden
            this.Write("/// <reference path=\'../../typings/index.d.ts\' />");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
