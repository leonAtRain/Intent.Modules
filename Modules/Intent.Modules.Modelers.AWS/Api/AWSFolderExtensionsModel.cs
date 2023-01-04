using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Types.Api;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementExtensionModel", Version = "1.0")]

namespace Intent.Modelers.AWS.Api
{
    [IntentManaged(Mode.Fully, Signature = Mode.Fully)]
    public class AWSFolderExtensionsModel : FolderModel
    {
        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public AWSFolderExtensionsModel(IElement element) : base(element)
        {
        }

        public IList<DTOModel> DTOs => _element.ChildElements
            .GetElementsOfType(DTOModel.SpecializationTypeId)
            .Select(x => new DTOModel(x))
            .ToList();

        public IList<DiagramModel> Diagrams => _element.ChildElements
            .GetElementsOfType(DiagramModel.SpecializationTypeId)
            .Select(x => new DiagramModel(x))
            .ToList();

        public IList<IAMPolicyStatementModel> IAMPolicyStatements => _element.ChildElements
            .GetElementsOfType(IAMPolicyStatementModel.SpecializationTypeId)
            .Select(x => new IAMPolicyStatementModel(x))
            .ToList();

    }
}