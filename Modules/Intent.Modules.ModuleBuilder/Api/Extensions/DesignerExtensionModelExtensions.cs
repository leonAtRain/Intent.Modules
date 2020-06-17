using System;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("ModuleBuilder.Templates.Api.ApiElementModelExtensions", Version = "1.0")]

namespace Intent.Modules.ModuleBuilder.Api
{
    public static class DesignerExtensionModelExtensions
    {
        public static DesignerSettings GetDesignerSettings(this DesignerExtensionModel model)
        {
            var stereotype = model.GetStereotype("Designer Settings");
            return stereotype != null ? new DesignerSettings(stereotype) : null;
        }

        public static bool HasDesignerSettings(this DesignerExtensionModel model)
        {
            return model.HasStereotype("Designer Settings");
        }


        public class DesignerSettings
        {
            private IStereotype _stereotype;

            public DesignerSettings(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public IIconModel Icon()
            {
                return _stereotype.GetProperty<IIconModel>("Icon");
            }

            public int? DisplayOrder()
            {
                return _stereotype.GetProperty<int?>("Display Order");
            }

            public bool IsReference()
            {
                return _stereotype.GetProperty<bool>("Is Reference");
            }

            public string APINamespace()
            {
                return _stereotype.GetProperty<string>("API Namespace");
            }

            public string NuGetPackageId()
            {
                return _stereotype.GetProperty<string>("NuGet Package Id");
            }

            public string NuGetPackageVersion()
            {
                return _stereotype.GetProperty<string>("NuGet Package Version");
            }

        }

    }
}