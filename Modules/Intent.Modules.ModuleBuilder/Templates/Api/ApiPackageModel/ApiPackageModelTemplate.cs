// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiPackageModel
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ApiPackageModelTemplate : CSharpTemplateBase<PackageSettingsModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Inten" +
                    "t.Metadata.Models;\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge)]\r\n    public class ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IHasStereotypes, IMetadataModel\r\n    {\r\n        public const string Specializa" +
                    "tionType = \"");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n        public const string SpecializationTypeId = \"");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Id));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        [IntentManaged(Mode.Ignore)]\r\n        public ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IPackage package)
        {
            if (!SpecializationType.Equals(package.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($""Cannot create a '{GetType().Name}' from package with specialization type '{package.SpecializationType}'. Must be of type '{SpecializationType}'"");
            }

            UnderlyingPackage = package;
        }

        public IPackage UnderlyingPackage { get; }
        public string Id => UnderlyingPackage.Id;
        public string Name => UnderlyingPackage.Name;
        public IEnumerable<IStereotype> Stereotypes => UnderlyingPackage.Stereotypes;
        public string FileLocation => UnderlyingPackage.FileLocation;

        ");
            
            #line 42 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
  if (Model.MenuOptions != null) {
        foreach(var creationOption in Model.MenuOptions.ElementCreations) {
            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 44 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FormatForCollection(creationOption.ApiModelName, creationOption.AllowMultiple())));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 44 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionName(creationOption)));
            
            #line default
            #line hidden
            this.Write(" => UnderlyingPackage.ChildElements\r\n            .Where(x => x.SpecializationType" +
                    " == ");
            
            #line 45 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(creationOption.ApiModelName));
            
            #line default
            #line hidden
            this.Write(".SpecializationType)\r\n            .Select(x => new ");
            
            #line 46 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(creationOption.ApiModelName));
            
            #line default
            #line hidden
            this.Write("(x))\r\n");
            
            #line 47 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
          if (creationOption.GetOptionSettings().AllowMultiple()) { 
            
            #line default
            #line hidden
            this.Write("            .ToList();\r\n");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
          } else { 
            
            #line default
            #line hidden
            this.Write("            .SingleOrDefault();\r\n");
            
            #line 51 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
          } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 53 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
      } 
            
            #line default
            #line hidden
            
            #line 54 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiPackageModel\ApiPackageModelTemplate.tt"
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