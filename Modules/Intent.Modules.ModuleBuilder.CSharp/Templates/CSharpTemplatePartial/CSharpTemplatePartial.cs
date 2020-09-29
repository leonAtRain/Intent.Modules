// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.Modules.ModuleBuilder.CSharp.Api;
    using Intent.Modules.ModuleBuilder.Api;
    using Intent.Modules.ModuleBuilder.Helpers;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class CSharpTemplatePartial : IntentRoslynProjectItemTemplateBase<CSharpTemplateModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System.Collections.Generic;\r\nusing Intent.Engine;\r\nusing Intent.Modules.Com" +
                    "mon.Templates;\r\nusing Intent.RoslynWeaver.Attributes;\r\nusing Intent.Templates;\r\n" +
                    "");
            
            #line 18 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GetModelType() != null ? string.Format("using {0};", Model.GetModelType().ParentModule.ApiNamespace) : ""));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Merge)]\r\n\r\nnamespace ");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t[IntentManaged(Mode.Merge, Signature = Mode.Fully)]\r\n    partial class ");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IntentRoslynProjectItemTemplateBase<");
            
            #line 25 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        [IntentManaged(Mode.Fully)]\r\n        public const string Templa" +
                    "teId = \"");
            
            #line 28 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTemplateId()));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        [IntentInitialGen]\r\n        public ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(IProject project, ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetModelType()));
            
            #line default
            #line hidden
            this.Write(@" model) : base(TemplateId, project, model)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetadata(Id, ""1.0""));
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        protected override RoslynDefaultFileMetadata DefineRoslynDefaultFileMetadata()
        {
            return new RoslynDefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: """);
            
            #line 45 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsFilePerModelTemplateRegistration() ? "${Model.Name}" : Model.Name.Replace("Template", "")));
            
            #line default
            #line hidden
            this.Write("\",\r\n                fileExtension: \"cs\",\r\n                defaultLocationInProjec" +
                    "t: \"");
            
            #line 47 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsFilePerModelTemplateRegistration() ? Model.Name.Replace("Template", "") : ""));
            
            #line default
            #line hidden
            this.Write("\",\r\n                className: \"");
            
            #line 48 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsFilePerModelTemplateRegistration() ? "${Model.Name}" : Model.Name.Replace("Template", "")));
            
            #line default
            #line hidden
            this.Write("\",\r\n                @namespace: \"${Project.Name}");
            
            #line 49 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IsFilePerModelTemplateRegistration() ? "." + Model.Name.Replace("Template", "") : ""));
            
            #line default
            #line hidden
            this.Write("\"\r\n            );\r\n        }\r\n\r\n");
            
            #line 53 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
  if (/*HasDecorators()*/false) { 
            
            #line default
            #line hidden
            this.Write("        [IntentManaged(Mode.Fully)]\r\n        public void AddDecorator(");
            
            #line 55 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("TODO Decorator Type"));
            
            #line default
            #line hidden
            this.Write(" decorator)\r\n        {\r\n            _decorators.Add(decorator);\r\n        }\r\n\r\n   " +
                    "     [IntentManaged(Mode.Fully)]\r\n        public IEnumerable<");
            
            #line 61 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("TODO Decorator Type"));
            
            #line default
            #line hidden
            this.Write("> GetDecorators()\r\n        {\r\n            return _decorators;\r\n        }\r\n");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.ModuleBuilder.CSharp\Templates\CSharpTemplatePartial\CSharpTemplatePartial.tt"
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
