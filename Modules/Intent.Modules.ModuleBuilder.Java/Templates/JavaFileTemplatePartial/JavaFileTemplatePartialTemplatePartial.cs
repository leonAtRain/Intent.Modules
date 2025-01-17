using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.ModuleBuilder.Java.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.CSharp.Templates;
using Intent.Modules.Common.Java.Templates;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.Types.Api;
using Intent.Modules.ModuleBuilder.Templates.IModSpec;
using Intent.Modules.ModuleBuilder.Templates.TemplateDecoratorContract;
using Intent.Modules.ModuleBuilder.Templates.TemplateExtensions;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.CSharp.Templates.CSharpTemplatePartial", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Java.Templates.JavaFileTemplatePartial
{
    [IntentManaged(Mode.Merge, Signature = Mode.Merge)]
    partial class JavaFileTemplatePartialTemplate : CSharpTemplateBase<JavaFileTemplateModel>, IModuleBuilderTemplate
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.ModuleBuilder.Java.Templates.JavaFileTemplatePartial";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public JavaFileTemplatePartialTemplate(IOutputTarget outputTarget, JavaFileTemplateModel model) : base(TemplateId, outputTarget, model)
        {
            AddNugetDependency("Intent.Modules.Common.Java", "3.4.3");
            AddNugetDependency("Intent.Modules.Java.Weaving.Annotations", "3.3.1");

            if (Model.GetModelType() != null)
            {
                AddUsing(Model.GetModelType().ParentModule.ApiNamespace);
            }
        }

        public string TemplateName => $"{Model.Name.ToCSharpIdentifier().RemoveSuffix("Template")}Template";
        public IList<string> OutputFolder => Model.GetParentFolders().Select(x => x.Name).Concat(new[] { Model.Name.ToCSharpIdentifier().RemoveSuffix("Template") }).ToList();
        public string FolderPath => string.Join("/", OutputFolder);
        public string FolderNamespace => string.Join(".", OutputFolder);

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        protected override CSharpFileConfig DefineFileConfig()
        {
            return new CSharpFileConfig(
                className: $"{TemplateName}",
                @namespace: $"{OutputTarget.GetNamespace()}.{FolderNamespace}",
                fileName: $"{TemplateName}Partial",
                relativeLocation: $"{FolderPath}");
        }

        public override void BeforeTemplateExecution()
        {
            ExecutionContext.EventDispatcher.Publish(new TemplateRegistrationRequiredEvent(this));
            ExecutionContext.EventDispatcher.Publish(new ModuleDependencyRequiredEvent(
                moduleId: "Intent.Common.Java",
                moduleVersion: "3.4.3"));
            if (Model.GetModelType() != null)
            {
                ExecutionContext.EventDispatcher.Publish(new ModuleDependencyRequiredEvent(
                    moduleId: Model.GetModelType().ParentModule.Name,
                    moduleVersion: Model.GetModelType().ParentModule.Version));
            }
        }
        
        private string GetAccessModifier()
        {
            if (Model.GetJavaTemplateSettings()?.TemplatingMethod()?.IsJavaFileBuilder() == true
                || Model.GetJavaTemplateSettings()?.TemplatingMethod()?.IsCustom() == true)
            {
                return "public partial ";
            }
            return "partial ";
        }

        public string TemplateType()
        {
            return "Java Template";
        }

        public string GetDefaultLocation()
        {
            return Model.GetLocation();
        }

        public string GetRole()
        {
            return Model.GetRole();
        }

        public string GetTemplateId()
        {
            return $"{Model.GetModule().Name}.{FolderNamespace}";
        }

        public string GetModelType()
        {
            return Model.GetModelName();
        }

        private IEnumerable<string> GetBaseTypes()
        {
            if (Model.DecoratorContract != null)
            {
                yield return $"JavaTemplateBase<{Model.GetModelName()}, {GetTypeName(TemplateDecoratorContractTemplate.TemplateId, Model.DecoratorContract)}>";
            }
            else
            {
                yield return $"JavaTemplateBase<{Model.GetModelName()}>";
            }

            if (Model.GetJavaTemplateSettings().TemplatingMethod().IsJavaFileBuilder())
            {
                yield return UseType(typeof(IJavaFileBuilderTemplate).FullName);
            }
        }
    }
}