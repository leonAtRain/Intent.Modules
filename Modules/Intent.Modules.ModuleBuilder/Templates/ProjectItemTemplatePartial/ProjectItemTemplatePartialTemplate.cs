// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.Templates.ProjectItemTemplatePartial
{
    using Intent.Modules.Common.Templates;
    using Intent.Metadata.Models;
    using Intent.Modules.ModuleBuilder.Helpers;
    using System.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ProjectItemTemplatePartialTemplate : IntentRoslynProjectItemTemplateBase<IClass>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"using Intent.Metadata.Models;
using Intent.RoslynWeaver.Attributes;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 19 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]\r\n   " +
                    " partial class ");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IntentProjectItemTemplateBase<");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(">");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetConfiguredInterfaces()));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public const string TemplateId = \"");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateId()));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
  if (HasDecorators()) { 
            
            #line default
            #line hidden
            this.Write("        private IEnumerable<");
            
            #line 27 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetExposedDecoratorContractType()));
            
            #line default
            #line hidden
            this.Write("> _decorators;\r\n\r\n");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("        [IntentInitialGen]\r\n        public ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IProject project, ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(@" model) : base(TemplateId, project, model)
        {
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: """);
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetCreationMode() == CreationMode.FilePerModel ? "${Model.Name}" : Model.Name.Replace("Template", "")));
            
            #line default
            #line hidden
            this.Write("\",\r\n                fileExtension: \"txt\", // Change to desired file extension.\r\n " +
                    "               defaultLocationInProject: \"");
            
            #line 43 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetCreationMode() == CreationMode.FilePerModel ? Model.Name.Replace("Template", "") : ""));
            
            #line default
            #line hidden
            this.Write("\"\r\n            );\r\n        }\r\n\r\n");
            
            #line 47 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
  if (HasDeclaresUsings()) { 
            
            #line default
            #line hidden
            this.Write(@"        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public IEnumerable<string> DeclareUsings()
        {
            return new string[]
            {
                // Specify list of Namespaces here, example:
                ""System.Linq""
            };
        }
");
            
            #line 57 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 59 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
  if (HasDecorators()) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully, Body = Mode.Fully, Signature = Mode.Fully)]\r\n " +
                    "       public IEnumerable<");
            
            #line 61 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetExposedDecoratorContractType()));
            
            #line default
            #line hidden
            this.Write("> GetDecorators()\r\n        {\r\n            return _decorators ?? (_decorators = Pr" +
                    "oject.ResolveDecorators(this));\r\n        }\r\n");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 67 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
  if (HasTemplateDependencies()) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully, Body = Mode.Fully, Signature = Mode.Fully)]\r\n " +
                    "       public IEnumerable<ITemplateDependancy> GetTemplateDependencies()\r\n      " +
                    "  {\r\n            var templateDependencies = new List<ITemplateDependancy>();\r\n");
            
            #line 72 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      foreach (var templateDependency in GetTemplateDependencies().Where(p => !p.IsCustom)) { 
            
            #line default
            #line hidden
            this.Write("                templateDependencies.Add(TemplateDependancy.OnTemplate(\"");
            
            #line 73 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateDependency.TemplateId));
            
            #line default
            #line hidden
            this.Write("\"));\r\n");
            
            #line 74 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      } 
            
            #line default
            #line hidden
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      if (GetTemplateDependencies().Any(p => p.IsCustom)) { 
            
            #line default
            #line hidden
            this.Write("                templateDependencies.AddRange(GetCustomTemplateDependencies());\r\n" +
                    "");
            
            #line 77 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("            return templateDependencies;\r\n        }\r\n\r\n");
            
            #line 81 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      foreach (var templateDependency in GetTemplateDependencies().Where(p => !p.IsCustom)) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully, Body = Mode.Fully, Signature = Mode.Fully)]\r\n " +
                    "       private string Get");
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateDependency.TemplateName.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("TemplateFullName(");
            
            #line 83 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateDependency.TemplateModel));
            
            #line default
            #line hidden
            this.Write(" model)\r\n        {\r\n            var templateDependency = TemplateDependancy.OnTem" +
                    "plate(\"");
            
            #line 85 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateDependency.TemplateId));
            
            #line default
            #line hidden
            this.Write("\");\r\n            var template = Project.FindTemplateInstance<");
            
            #line 86 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(templateDependency.InstanceType));
            
            #line default
            #line hidden
            this.Write(">(templateDependency, model);\r\n            return NormalizeNamespace($\"{template." +
                    "Namespace}.{template.ClassName}\");\r\n        }\r\n");
            
            #line 89 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 91 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      if (GetTemplateDependencies().Any(p => p.IsCustom)) { 
            
            #line default
            #line hidden
            this.Write(@"        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        private IEnumerable<ITemplateDependancy> GetCustomTemplateDependencies()
        {
            return new ITemplateDependancy[] 
            {
            };
        }
");
            
            #line 99 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
      } 
            
            #line default
            #line hidden
            
            #line 100 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder\Templates\ProjectItemTemplatePartial\ProjectItemTemplatePartialTemplate.tt"
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
