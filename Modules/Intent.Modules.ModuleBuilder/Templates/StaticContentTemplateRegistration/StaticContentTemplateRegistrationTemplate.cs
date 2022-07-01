﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.StaticContentTemplateRegistration
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.CSharp.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.ModuleBuilder.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class StaticContentTemplateRegistrationTemplate : CSharpTemplateBase<Intent.ModuleBuilder.Api.StaticContentTemplateModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 14 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UseType("Intent.Modules.Common.Templates.StaticContent.StaticContentTemplateRegistration")));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public new const string TemplateId = \"");
            
            #line 18 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateId()));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("() : base(TemplateId)\r\n        {\r\n        }\r\n");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"

	var contentSubfolder = Model.GetTemplateSettings().ContentSubfolder();
	if (!string.IsNullOrWhiteSpace(contentSubfolder))
	{

            
            #line default
            #line hidden
            this.Write("\r\n        public override string ContentSubFolder => \"");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(contentSubfolder));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\StaticContentTemplateRegistration\StaticContentTemplateRegistrationTemplate.tt"

	}

            
            #line default
            #line hidden
            this.Write("\r\n        [IntentManaged(Mode.Merge, Signature = Mode.Fully, Body = Mode.Ignore)]\r\n        public override IReadOnlyDictionary<string, string> Replacements => new Dictionary<string, string>\r\n        {\r\n        };\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
}
