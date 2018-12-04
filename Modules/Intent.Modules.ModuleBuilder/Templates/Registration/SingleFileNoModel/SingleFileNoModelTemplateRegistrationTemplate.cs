// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Registration.SingleFileNoModel
{
    using Intent.Modules.Common.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileNoModel\SingleFileNoModelTemplateRegistrationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class SingleFileNoModelTemplateRegistrationTemplate : IntentRoslynProjectItemTemplateBase<IClass>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Registrations;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.Templates.Registrations;
");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileNoModel\SingleFileNoModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileNoModel\SingleFileNoModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]\r\n   " +
                    " public class ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileNoModel\SingleFileNoModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : NoModelTemplateRegistrationBase\r\n    {\r\n        public override string Templat" +
                    "eId =>  ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileNoModel\SingleFileNoModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateNameForTemplateId()));
            
            #line default
            #line hidden
            this.Write(".TemplateId;\r\n\r\n        public override ITemplate CreateTemplateInstance(IProject" +
                    " project)\r\n        {\r\n\t\t\treturn new ");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Registration\SingleFileNoModel\SingleFileNoModelTemplateRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateNameForTemplateId()));
            
            #line default
            #line hidden
            this.Write("(project, null);\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
