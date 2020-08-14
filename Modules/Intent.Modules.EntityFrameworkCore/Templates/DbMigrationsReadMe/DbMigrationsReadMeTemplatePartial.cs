﻿using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.VisualStudio;
using Intent.Modules.EntityFrameworkCore.Templates.DbContext;
using Intent.Templates;

namespace Intent.Modules.EntityFrameworkCore.Templates.DbMigrationsReadMe
{
    partial class DbMigrationsReadMeTemplate : IntentProjectItemTemplateBase<object>, ITemplate, IHasNugetDependencies
    {
        public const string Identifier = "Intent.EntityFrameworkCore.DbMigrationsReadMe";


        public DbMigrationsReadMeTemplate(IProject project)
            : base(Identifier, project, null)
        {
        }

        public string BoundedContextName => Project.ApplicationName();
        public string MigrationProject => Project.Name;
        public string ProjectWithDbContext => ExecutionContext.FindOutputTargetWithTemplateInstance(TemplateDependency.OnTemplate(DbContextTemplate.Identifier))?.Name ?? "<UNKNOWN-DB-CONTEXT-PROJECT>";

        public override ITemplateFileConfig DefineDefaultFileMetadata()
        {
            return new DefaultFileMetadata(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: "MIGRATION_README",
                fileExtension: "txt",
                defaultLocationInProject: "");
        }

        public IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.EntityFrameworkCoreDesign,
                NugetPackages.EntityFrameworkCoreTools,
            }
            .ToArray();
        }
    }
}
