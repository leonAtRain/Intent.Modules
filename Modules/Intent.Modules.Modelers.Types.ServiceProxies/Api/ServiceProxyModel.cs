using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.Modelers.Types.ServiceProxies.Api
{
    [IntentManaged(Mode.Merge)]
    public class ServiceProxyModel : IMetadataModel, IHasStereotypes, IHasName
    {
        public const string SpecializationType = "Service Proxy";
        public const string SpecializationTypeId = "07d8d1a9-6b9f-4676-b7d3-8db06299e35c";
        protected readonly IElement _element;

        [IntentManaged(Mode.Ignore)]
        public ServiceProxyModel(IElement element, string requiredType = SpecializationType)
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

        public bool IsMapped => _element.IsMapped;

        public IElementMapping Mapping => _element.MappedElement;

        public IElement InternalElement => _element;

        public ServiceModel MappedService => Mapping != null ? new ServiceModel((IElement)Mapping.Element) : null;

        public IList<OperationModel> Operations => _element.ChildElements
            .GetElementsOfType(OperationModel.SpecializationTypeId)
            .Select(x => new OperationModel(x))
            .ToList();

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(ServiceProxyModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ServiceProxyModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }

        public string Comment => _element.Comment;
    }

    [IntentManaged(Mode.Fully)]
    public static class ServiceProxyModelExtensions
    {

        public static bool IsServiceProxyModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == ServiceProxyModel.SpecializationTypeId;
        }

        public static ServiceProxyModel AsServiceProxyModel(this ICanBeReferencedType type)
        {
            return type.IsServiceProxyModel() ? new ServiceProxyModel((IElement)type) : null;
        }

        public static bool HasServiceReferenceMapping(this ServiceProxyModel type)
        {
            return type.Mapping?.MappingSettingsId == "df491bea-8a85-4bc9-a93d-41b7abb80ffb";
        }

        public static IElementMapping GetServiceReferenceMapping(this ServiceProxyModel type)
        {
            return type.HasServiceReferenceMapping() ? type.Mapping : null;
        }
    }
}