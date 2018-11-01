﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Intent.MetaModel.Common;
using Intent.MetaModel.Domain;
using Intent.Modules.Common.Templates;
using Intent.Modules.Entities.Templates.DomainEntityInterface;
using Intent.Modules.Entities.Templates.DomainEntityState;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.Entities.Templates.DomainEntity
{
    partial class DomainEntityTemplate : IntentRoslynProjectItemTemplateBase<IClass>, ITemplate, IHasDecorators<DomainEntityDecoratorBase>, IPostTemplateCreation
    {
        public const string Identifier = "Intent.Entities.DomainEntity";
        private IEnumerable<DomainEntityDecoratorBase> _decorators;

        public DomainEntityTemplate(IClass model, IProject project)
            : base(Identifier, project, model)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, new TemplateVersion(1, 0)));
        }

        public void Created()
        {
            //Types.AddClassTypeSource(ClassTypeSource.InProject(Project, DomainEntityTemplate.Identifier, nameof(ICollection)));
            Types.AddClassTypeSource(ClassTypeSource.InProject(Project, DomainEntityInterfaceTemplate.Identifier, nameof(IEnumerable)));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "${Model.Name}",
                fileExtension: "cs",
                defaultLocationInProject: "Domain",
                className: "${Model.Name}",
                @namespace: "${Project.ProjectName}"
                );
        }

        public IEnumerable<DomainEntityDecoratorBase> GetDecorators()
        {
            if (_decorators == null)
            {
                _decorators = Project.ResolveDecorators(this);
                foreach (var decorator in _decorators)
                {
                    decorator.Template = this;
                }
            }
            return _decorators;
        }

        public string Constructors(IClass @class)
        {
            return GetDecorators().Aggregate(x => x.Constructors(@class));
        }

        public string GetParametersDefinition(IOperation operation)
        {
            return operation.Parameters.Any() 
                ? operation.Parameters.Select(x => this.ConvertType(x.Type) + " " + x.Name.ToCamelCase()).Aggregate((x, y) => x + ", " + y) 
                : "";
        }

        public string EmitOperationReturnType(IOperation operation)
        {
            return operation.ReturnType != null ? this.ConvertType(operation.ReturnType.Type) : "void";
        }


    }
}
