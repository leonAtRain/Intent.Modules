using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.ModuleBuilder.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TemplateRegistration.FilePerModel", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Templates.StaticContentOutputReadme
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    public class StaticContentOutputReadmeTemplateRegistration : FilePerModelTemplateRegistration<StaticContentTemplateModel>
    {
        private readonly IMetadataManager _metadataManager;

        public StaticContentOutputReadmeTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => StaticContentOutputReadmeTemplate.TemplateId;

        public override ITemplate CreateTemplateInstance(IOutputTarget outputTarget, StaticContentTemplateModel model)
        {
            return new StaticContentOutputReadmeTemplate(outputTarget, model);
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override IEnumerable<StaticContentTemplateModel> GetModels(IApplication application)
        {
            return _metadataManager.ModuleBuilder(application).GetStaticContentTemplateModels();
        }
    }
}