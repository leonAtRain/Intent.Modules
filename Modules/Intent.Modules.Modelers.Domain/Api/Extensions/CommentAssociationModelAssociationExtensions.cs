using System.Collections.Generic;
using System.Linq;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiAssociationModelExtensions", Version = "1.0")]

namespace Intent.Modelers.Domain.Api
{
    public static class CommentAssociationModelAssociationExtensions
    {
        [IntentManaged(Mode.Fully)]
        public static IList<CommentTargetEndModel> CommentedClasses(this CommentModel model)
        {
            return model.InternalElement.AssociatedElements
                .Where(x => x.Association.SpecializationType == CommentAssociationModel.SpecializationType && x.IsTargetEnd())
                .Select(x => CommentAssociationModel.CreateFromEnd(x).TargetEnd)
                .ToList();
        }

        [IntentManaged(Mode.Fully)]
        public static IList<CommentSourceEndModel> AssociatedComments(this ClassModel model)
        {
            return model.InternalElement.AssociatedElements
                .Where(x => x.Association.SpecializationType == CommentAssociationModel.SpecializationType && x.IsSourceEnd())
                .Select(x => CommentAssociationModel.CreateFromEnd(x).SourceEnd)
                .ToList();
        }

    }
}