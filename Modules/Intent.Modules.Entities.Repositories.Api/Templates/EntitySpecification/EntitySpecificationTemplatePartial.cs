﻿using System.Collections.Generic;
using Intent.MetaModel.Domain;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;

namespace Intent.Modules.Entities.Repositories.Api.Templates.EntitySpecification
{
    partial class EntitySpecificationTemplate : IntentRoslynProjectItemTemplateBase<IClass>, ITemplate, IPostTemplateCreation
    {
        public const string Identifier = "Intent.Entities.Repositories.Api.EntitySpecification";
        private ITemplateDependancy _entityStateTemplateDependancy;

        public EntitySpecificationTemplate(IClass model, IProject project)
            : base(Identifier, project, model)
        {
        }

        public void Created()
        {
            _entityStateTemplateDependancy = TemplateDependancy.OnModel<IClass>(GetMetaData().CustomMetaData["Entity Template Id"], (to) => to.Id == Model.Id);
        }

        public string EntityStateName => Project.FindTemplateInstance<IHasClassDetails>(_entityStateTemplateDependancy)?.ClassName ?? Model.Name;

        public string BaseClass => $"DomainSpecificationBase<{EntityStateName}, {ClassName}>";

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, new TemplateVersion(1, 0)));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "${Model.Name}Specification",
                fileExtension: "cs",
                defaultLocationInProject: "Specifications",
                className: "${Model.Name}Specification",
                @namespace: "${Project.ProjectName}"
                );
        }

        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                new NugetPackageInfo("Intent.Framework.Domain", "1.0.0", null),
            };
        }
    }
}