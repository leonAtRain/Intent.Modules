using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiMetadataPackageExtensions", Version = "1.0")]

namespace Intent.Modelers.Eventing.Api
{
    public static class ApiMetadataPackageExtensions
    {
        public static IList<EventingPackageModel> GetEventingPackageModels(this IDesigner designer)
        {
            return designer.GetPackagesOfType(EventingPackageModel.SpecializationTypeId)
                .Select(x => new EventingPackageModel(x))
                .ToList();
        }


    }
}