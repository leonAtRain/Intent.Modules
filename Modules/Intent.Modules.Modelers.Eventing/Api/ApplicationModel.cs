using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.Modelers.Eventing.Api
{
    [IntentManaged(Mode.Merge)]
    public class ApplicationModel : IMetadataModel, IHasStereotypes, IHasName
    {
        public const string SpecializationType = "Application";
        public const string SpecializationTypeId = "f40a4942-5d2d-4174-8ec1-af66cbd464db";
        protected readonly IElement _element;

        [IntentManaged(Mode.Ignore)]
        public ApplicationModel(IElement element, string requiredType = SpecializationType)
        {
            if (!requiredType.Equals(element.SpecializationType, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception($"Cannot create a '{GetType().Name}' from element with specialization type '{element.SpecializationType}'. Must be of type '{SpecializationType}'");
            }
            _element = element;
        }

        public string Id => _element.Id;

        public string Name => _element.Name;

        public string Comment => _element.Comment;

        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;

        public IElement InternalElement => _element;

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(ApplicationModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ApplicationModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }
    }

    [IntentManaged(Mode.Fully)]
    public static class ApplicationModelExtensions
    {

        public static bool IsApplicationModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == ApplicationModel.SpecializationTypeId;
        }

        public static ApplicationModel AsApplicationModel(this ICanBeReferencedType type)
        {
            return type.IsApplicationModel() ? new ApplicationModel((IElement)type) : null;
        }
    }
}