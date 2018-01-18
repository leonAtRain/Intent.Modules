﻿using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.VisualStudio.Projects.Templates.AssemblyInfo
{
    partial class AssemblyInfoTemplate : IntentProjectItemTemplateBase<object>, ITemplate
    {
        public const string Identifier = "Intent.VisualStudio.Projects.AssemblyInfo";

        public AssemblyInfoTemplate(IProject project)
            : base (Identifier, project, null)
        {
        }

        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.OnceOff,
                codeGenType: CodeGenType.Basic,
                fileName: "AssemblyInfo",
                fileExtension: "cs",
                defaultLocationInProject: "Properties"
                );
        }
    }
}
