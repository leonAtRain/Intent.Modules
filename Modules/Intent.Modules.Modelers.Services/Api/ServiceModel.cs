using System;
using System.Collections.Generic;
using Intent.Metadata.Models;
using System.Linq;
using Intent.RoslynWeaver.Attributes;

[assembly: IntentTemplate("ModuleBuilder.Templates.Api.ApiModelImplementationTemplate", Version = "1.0")]
[assembly: DefaultIntentManaged(Mode.Merge)]

namespace Intent.Modelers.Services.Api
{
    [IntentManaged(Mode.Merge, Signature = Mode.Merge)]
    public class ServiceModel : IHasStereotypes, IMetadataModel, IHasFolder
    {
        protected readonly IElement _element;
        public ServiceModel(IElement element)
        {
            _element = element;
            Folder = _element.ParentElement?.SpecializationType == Api.FolderModel.SpecializationType ? new FolderModel(_element.ParentElement) : null;
        }

        public string Id => _element.Id;
        public IEnumerable<IStereotype> Stereotypes => _element.Stereotypes;
        public FolderModel Folder { get; }
        public string Name => _element.Name;
        public string ApplicationName => _element.Application.Name;
        public IElementApplication Application => _element.Application;

        [IntentManaged(Mode.Fully)]
        public IList<OperationModel> Operations => _element.ChildElements
            .Where(x => x.SpecializationType == Api.OperationModel.SpecializationType)
            .Select(x => new OperationModel(x))
            .ToList<OperationModel>();
        public string Comment => _element.Id;

        public override string ToString()
        {
            return $"Service: {Name}";
        }

        protected bool Equals(ServiceModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ServiceModel)obj);
        }

        public override int GetHashCode()
        {
            return (Id != null ? Id.GetHashCode() : 0);
        }
        public const string SpecializationType = "Service";
    }
}