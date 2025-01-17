using System;
using System.Collections.Generic;
using System.Linq;
using Intent.IArchitect.Agent.Persistence.Model.Common;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.ModuleBuilder.Api
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public class PackageEventSettingsModel : IMetadataModel, IHasStereotypes, IHasName
    {
        public const string SpecializationType = "Package Event Settings";
        protected readonly IElement _element;

        [IntentManaged(Mode.Ignore)]
        public PackageEventSettingsModel(IElement element, string requiredType = SpecializationType)
        {
            if (!requiredType.Equals(element.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($"Cannot create a '{GetType().Name}' from element with specialization type '{element.SpecializationType}'. Must be of type '{SpecializationType}'");
            }
            _element = element;
        }

        [IntentManaged(Mode.Fully)]
        public string Id => _element.Id;

        [IntentManaged(Mode.Fully)]
        public string Name => _element.Name;

        [IntentManaged(Mode.Fully)]
        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;

        [IntentManaged(Mode.Fully)]
        public IElement InternalElement => _element;

        [IntentManaged(Mode.Fully)]
        public IList<ElementEventHandlerModel> OnLoadedEvents => _element.ChildElements
            .GetElementsOfType(ElementEventHandlerModel.SpecializationTypeId)
            .Select(x => new ElementEventHandlerModel(x))
            .ToList();

        [IntentManaged(Mode.Fully)]
        public IList<ElementEventHandlerModel> OnCreatedEvents => _element.ChildElements
            .GetElementsOfType(ElementEventHandlerModel.SpecializationTypeId)
            .Select(x => new ElementEventHandlerModel(x))
            .ToList();

        public IList<ElementEventHandlerModel> OnChangedEvents => _element.ChildElements
            .GetElementsOfType(ElementEventHandlerModel.SpecializationTypeId)
            .Select(x => new ElementEventHandlerModel(x))
            .ToList();

        public List<ElementMacroPersistable> ToPersistable()
        {
            // TODO: The OnCreatedEvents & OnLoadedEvents returns all ElementMacroModels. Need solution
            return OnCreatedEvents.Select(x => x.ToPersistable()).ToList();
        }

        [IntentManaged(Mode.Fully)]
        public override string ToString()
        {
            return _element.ToString();
        }

        [IntentManaged(Mode.Fully)]
        public bool Equals(PackageEventSettingsModel other)
        {
            return Equals(_element, other?._element);
        }

        [IntentManaged(Mode.Fully)]
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PackageEventSettingsModel)obj);
        }

        [IntentManaged(Mode.Fully)]
        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }
        public const string SpecializationTypeId = "48bcdd5f-690c-425b-8f5e-99097a7188dc";

        public string Comment => _element.Comment;
    }

    [IntentManaged(Mode.Fully)]
    public static class PackageEventSettingsModelExtensions
    {

        public static bool IsPackageEventSettingsModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == PackageEventSettingsModel.SpecializationTypeId;
        }

        public static PackageEventSettingsModel AsPackageEventSettingsModel(this ICanBeReferencedType type)
        {
            return type.IsPackageEventSettingsModel() ? new PackageEventSettingsModel((IElement)type) : null;
        }
    }
}