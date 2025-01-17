using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.Modules.ApplicationTemplate.Builder.Api
{
    [IntentManaged(Mode.Merge)]
    public class InstallationSettingsModel : IMetadataModel, IHasStereotypes, IHasName
    {
        public const string SpecializationType = "Installation Settings";
        public const string SpecializationTypeId = "76db4fe8-5c95-4240-8f25-48b8079fa4ae";
        protected readonly IElement _element;

        [IntentManaged(Mode.Ignore)]
        public InstallationSettingsModel(IElement element, string requiredType = SpecializationType)
        {
            if (!requiredType.Equals(element.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($"Cannot create a '{GetType().Name}' from element with specialization type '{element.SpecializationType}'. Must be of type '{SpecializationType}'");
            }
            _element = element;
        }

        public string Id => _element.Id;

        public string Name => _element.Name;

        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;

        public IElement InternalElement => _element;

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(InstallationSettingsModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((InstallationSettingsModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }

        public string Comment => _element.Comment;
    }

    [IntentManaged(Mode.Fully)]
    public static class InstallationSettingsModelExtensions
    {

        public static bool IsInstallationSettingsModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == InstallationSettingsModel.SpecializationTypeId;
        }

        public static InstallationSettingsModel AsInstallationSettingsModel(this ICanBeReferencedType type)
        {
            return type.IsInstallationSettingsModel() ? new InstallationSettingsModel((IElement)type) : null;
        }
    }
}