using System.Collections.Generic;
using Intent.Engine;
using Intent.ModuleBuilder.Java.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Java.Templates.JavaFileStringInterpolationTemplate
{
    [IntentManaged(Mode.Fully, Body = Mode.Merge)]
    partial class JavaFileStringInterpolationTemplate : CSharpTemplateBase<JavaFileTemplateModel>
    {
        public const string TemplateId = "Intent.ModuleBuilder.Java.Templates.JavaFileStringInterpolationTemplate";

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public JavaFileStringInterpolationTemplate(IOutputTarget outputTarget, JavaFileTemplateModel model) : base(TemplateId, outputTarget, model)
        {
        }

        public string TemplateName => $"{Model.Name.ToCSharpIdentifier().RemoveSuffix("Template")}Template";

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: $"{TemplateName}",
                @namespace: $"{this.GetNamespace(additionalFolders: Model.Name.ToCSharpIdentifier().RemoveSuffix("Template"))}",
                relativeLocation: $"{this.GetFolderPath(additionalFolders: Model.Name.ToCSharpIdentifier().RemoveSuffix("Template"))}")
            {
                AutoFormat = false
            };
        }

        private bool IsForInterface()
        {
            return Model.Name.RemoveSuffix("Template").EndsWith("Interface");
        }
    }
}