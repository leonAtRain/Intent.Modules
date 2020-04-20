// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.Api.ApiElementModel
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.Modules.ModuleBuilder.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ApiElementModel : IntentRoslynProjectItemTemplateBase<ElementSettingsModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing Inten" +
                    "t.Metadata.Models;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace " +
                    "");
            
            #line 17 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n    public class ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BaseType != null ? (BaseType + ", ") : ""));
            
            #line default
            #line hidden
            this.Write("IHasStereotypes, IMetadataModel\r\n    {\r\n");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
  if (BaseType == null) { 
            
            #line default
            #line hidden
            this.Write("        public const string SpecializationType = \"");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n        protected readonly IElement _element;\r\n\r\n        [IntentInitialGen]\r\n" +
                    "        public ");
            
            #line 27 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IElement element, string requiredType = SpecializationType)
        {
            if (!requiredType.Equals(element.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($""Cannot create a '{GetType().Name}' from element with specialization type '{element.SpecializationType}'. Must be of type '{SpecializationType}'"");
            }
            _element = element;
        }

        public string Id => _element.Id;
        
        public string Name => _element.Name;
        
        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;

");
            
            #line 42 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
      if (!Model.GetTypeReferenceSettings().Mode().IsDisabled()) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully)]\r\n        public ITypeReference TypeReference " +
                    "=> _element.TypeReference;\r\n\r\n");
            
            #line 46 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
      } 
            
            #line default
            #line hidden
            
            #line 47 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
  } else { 
            
            #line default
            #line hidden
            this.Write("        public new const string SpecializationType = \"");
            
            #line 48 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public ");
            
            #line 50 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IElement element) : base(element, SpecializationType)\r\n        {\r\n        }\r\n\r\n");
            
            #line 54 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
  } 
            
            #line default
            #line hidden
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
  if (Model.MenuOptions != null) {
        foreach(var creationOption in Model.MenuOptions.CreationOptions.Where(x => !(x.Type is CoreTypeModel))) { 
            if (ExistsInBase(creationOption))
                continue;
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully)]\r\n        public ");
            
            #line 60 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionTypeClass(creationOption, creationOption.GetOptionSettings().AllowMultiple())));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 60 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionName(creationOption)));
            
            #line default
            #line hidden
            this.Write(" => _element.");
            
            #line 60 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((creationOption.Type is ElementSettingsModel) ? "ChildElement" : "OwnedAssociations"));
            
            #line default
            #line hidden
            this.Write("\r\n            .Where(x => x.SpecializationType == ");
            
            #line 61 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionTypeClass(creationOption)));
            
            #line default
            #line hidden
            this.Write(".SpecializationType)\r\n            .Select(x => new ");
            
            #line 62 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetCreationOptionTypeClass(creationOption)));
            
            #line default
            #line hidden
            this.Write("(x))\r\n");
            
            #line 63 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
      if (creationOption.GetOptionSettings().AllowMultiple()) { 
            
            #line default
            #line hidden
            this.Write("            .ToList();\r\n");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
      } else { 
            
            #line default
            #line hidden
            this.Write("            .SingleOrDefault();\r\n");
            
            #line 67 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
      } 
            
            #line default
            #line hidden
            
            #line 68 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
      }
    }
            
            #line default
            #line hidden
            this.Write("\r\n        [IntentManaged(Mode.Fully)]\r\n        public bool Equals(");
            
            #line 72 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@" other)
        {
            return Equals(_element, other._element);
        }

        [IntentManaged(Mode.Fully)]
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((");
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\Api\ApiElementModel\ApiElementModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(")obj);\r\n        }\r\n\r\n        [IntentManaged(Mode.Fully)]\r\n        public override" +
                    " int GetHashCode()\r\n        {\r\n            return (_element != null ? _element.G" +
                    "etHashCode() : 0);\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
