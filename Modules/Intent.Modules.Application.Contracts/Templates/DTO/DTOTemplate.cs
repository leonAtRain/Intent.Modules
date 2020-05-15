﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Application.Contracts.Templates.DTO
{
    using Intent.Modelers.Services.Api;
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class DTOTemplate : Intent.Modules.Common.Templates.IntentRoslynProjectItemTemplateBase<DTOModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\nusing System;\r\nusing System.Collections.Generic;\r\n");
            
            #line 15 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
 
    foreach (var line in Model.GetXmlDocLines())
    {

            
            #line default
            #line hidden
            this.Write("    /// ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(line));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassAttributes()));
            
            #line default
            #line hidden
            this.Write("\r\n    public class ");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenericTypes));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public ");
            
            #line 32 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n        }\r\n\r\n        public static ");
            
            #line 36 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            
            #line 36 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenericTypes));
            
            #line default
            #line hidden
            this.Write(" Create");
            
            #line 36 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenericTypes));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 36 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorParameters()));
            
            #line default
            #line hidden
            this.Write(") \r\n        {\r\n            return new ");
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            
            #line 38 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenericTypes));
            
            #line default
            #line hidden
            this.Write("\r\n            {\r\n");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
 foreach (var field in Model.Fields) {
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name.ToCamelCase(reservedWordEscape: true)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 42 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("            };\r\n        }\r\n");
            
            #line 45 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"

    foreach (var field in Model.Fields)
    {

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"

        foreach (var line in field.GetXmlDocLines())
        {

            
            #line default
            #line hidden
            this.Write("        /// ");
            
            #line 54 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(line));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 58 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyAttributes(field)));
            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 59 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeInfo(field.TypeReference)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 59 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(" {get; set;}\r\n");
            
            #line 60 "C:\Dev\Intent.Modules\Modules\Intent.Modules.Application.Contracts\Templates\DTO\DTOTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
