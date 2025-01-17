using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModel", Version = "1.0")]

namespace Intent.Modelers.Domain.Api
{
    [IntentManaged(Mode.Merge)]
    public class ClassConstructorModel : IMetadataModel, IHasStereotypes, IHasName
    {
        public const string SpecializationType = "Class Constructor";
        public const string SpecializationTypeId = "dec2bd12-4699-4f45-8ec9-3b62dc692d2b";
        protected readonly IElement _element;

        [IntentManaged(Mode.Ignore)]
        public ClassConstructorModel(IElement element, string requiredType = SpecializationType)
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

        [IntentManaged(Mode.Ignore)] public ClassModel ParentClass => new ClassModel(InternalElement.ParentElement);

        public IList<ParameterModel> Parameters => _element.ChildElements
            .GetElementsOfType(ParameterModel.SpecializationTypeId)
            .Select(x => new ParameterModel(x))
            .ToList();

        public override string ToString()
        {
            return _element.ToString();
        }

        public bool Equals(ClassConstructorModel other)
        {
            return Equals(_element, other?._element);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ClassConstructorModel)obj);
        }

        public override int GetHashCode()
        {
            return (_element != null ? _element.GetHashCode() : 0);
        }

        public bool IsMapped => _element.IsMapped;

        public IElementMapping Mapping => _element.MappedElement;

        public string Comment => _element.Comment;
    }

    [IntentManaged(Mode.Fully)]
    public static class ClassConstructorModelExtensions
    {

        public static bool IsClassConstructorModel(this ICanBeReferencedType type)
        {
            return type != null && type is IElement element && element.SpecializationTypeId == ClassConstructorModel.SpecializationTypeId;
        }

        public static ClassConstructorModel AsClassConstructorModel(this ICanBeReferencedType type)
        {
            return type.IsClassConstructorModel() ? new ClassConstructorModel((IElement)type) : null;
        }

        public static bool HasMapConstructorMapping(this ClassConstructorModel type)
        {
            return type.Mapping?.MappingSettingsId == "d6d0abfd-893c-4bec-92cb-419934ba5ba8";
        }

        public static IElementMapping GetMapConstructorMapping(this ClassConstructorModel type)
        {
            return type.HasMapConstructorMapping() ? type.Mapping : null;
        }
    }
}