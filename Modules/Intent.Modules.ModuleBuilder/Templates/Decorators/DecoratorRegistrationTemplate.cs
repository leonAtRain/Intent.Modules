﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Decorators
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Intent.Modules.Common.Templates;
    using Intent.Metadata.Models;
    using Intent.Modules.ModuleBuilder.Api;
    using Intent.Modules.ModuleBuilder.Helpers;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Decorators\DecoratorRegistrationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class DecoratorRegistrationTemplate : IntentRoslynProjectItemTemplateBase<IDecoratorDefinition>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing Intent.Modules.Common.Registrations;\r\nusing Intent.SoftwareF" +
                    "actory.Engine;\r\n");
            
            #line 13 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Decorators\DecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Decorators\DecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]\r\n" +
                    "    public class ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Decorators\DecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : DecoratorRegistration<");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Decorators\DecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetImplementerDecoratorContractType()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public override string DecoratorId => ");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Decorators\DecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorTemplateFullName(Model)));
            
            #line default
            #line hidden
            this.Write(".Identifier;\r\n\r\n        public override object CreateDecoratorInstance(IApplicati" +
                    "on application)\r\n        {\r\n            return new ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Decorators\DecoratorRegistrationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorTemplateFullName(Model)));
            
            #line default
            #line hidden
            this.Write("(application);\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
