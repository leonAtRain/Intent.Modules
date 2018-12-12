using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.VisualStudio;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.ModuleBuilder.Templates.ReadMe
{
    partial class ReadMeTemplate : IntentProjectItemTemplateBase
    {
        public const string TemplateId = "Intent.ModuleBuilder.ReadMe";

        public ReadMeTemplate(IProject project) : base(TemplateId, project)
        {
        }

        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: "README",
                fileExtension: "txt",
                defaultLocationInProject: ""
            );
        }
    }
}