﻿using System;
using System.Collections.Generic;
using System.Linq;
using Intent.MetaModel.Common;
using Intent.MetaModel.Service;
using Intent.Modules.Application.Contracts;
using Intent.Modules.Application.Contracts.Templates.DTO;
using Intent.Modules.Application.Contracts.Templates.ServiceContract;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.Modules.Common.VisualStudio;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.AspNetCore.WebApi.Templates.Controller
{
    partial class WebApiControllerTemplate : IntentRoslynProjectItemTemplateBase<IServiceModel>, ITemplate, IHasTemplateDependencies, IHasAssemblyDependencies, IHasNugetDependencies, IHasDecorators<WebApiControllerDecoratorBase>, IDeclareUsings, IPostTemplateCreation
    {
        public const string Identifier = "Intent.AspNetCore.WebApi.Controller";
        private IEnumerable<WebApiControllerDecoratorBase> _decorators;

        public WebApiControllerTemplate(IProject project, IServiceModel model)
            : base(Identifier, project, model)
        {
        }

        public void Created()
        {
            Types.AddClassTypeSource(ClassTypeSource.InProject(Project, DTOTemplate.IDENTIFIER, "List"));
        }

        public IEnumerable<string> DeclareUsings()
        {
            return GetDecorators().SelectMany(x => x.DeclareUsings(Model));
        }

        public IEnumerable<ITemplateDependancy> GetTemplateDependencies()
        {
            return new[]
            {
                TemplateDependancy.OnTemplate(ServiceContractTemplate.IDENTIFIER)
            };
        }

        public IEnumerable<IAssemblyReference> GetAssemblyDependencies()
        {
            return new IAssemblyReference[]
            {
                new GacAssemblyReference("System.Transactions")
            };
        }

        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.AspNetCoreAll,
            }
            .Union(base.GetNugetDependencies())
            .ToArray();
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "${Model.Name}Controller",
                fileExtension: "cs",
                defaultLocationInProject: "Controllers",
                className: "${Model.Name}Controller",
                @namespace: "${Project.Name}.Controller"
                );
        }

        public string GetServiceInterfaceName()
        {
            var serviceContractTemplate = Project.Application.FindTemplateInstance<IHasClassDetails>(TemplateDependancy.OnModel<ServiceModel>(ServiceContractTemplate.IDENTIFIER, x => x.Id == Model.Id));
            return NormalizeNamespace($"{serviceContractTemplate.Namespace}.{serviceContractTemplate.ClassName}");
        }

        private string GetRoute()
        {
            return Model.GetStereotypeProperty("Http", "Route", "api/[controller]");
        }

        private string GetTypeName(ITypeReference typeInfo)
        {
            return NormalizeNamespace(Types.Get(typeInfo, "List"));
        }

        public string DeclarePrivateVariables()
        {
            return GetDecorators().Aggregate(x => x.DeclarePrivateVariables(Model));
        }

        public string ConstructorParams()
        {
            return GetDecorators().Aggregate(x => x.ConstructorParams(Model));
        }

        public string ConstructorInit()
        {
            return GetDecorators().Aggregate(x => x.ConstructorInit(Model));
        }

        public IEnumerable<string> PayloadPropertyDecorators(IOperationParameterModel parameter)
        {
            return GetDecorators().SelectMany(x => x.PayloadPropertyDecorators(parameter));
        }

        public string BeginOperation(IOperationModel operation)
        {
            return GetDecorators().Aggregate(x => x.BeginOperation(Model, operation));
        }

        public string BeforeTransaction(IOperationModel operation)
        {
            return GetDecorators().Aggregate(x => x.BeforeTransaction(Model, operation));
        }

        public string BeforeCallToAppLayer(IOperationModel operation)
        {
            return GetDecorators().Aggregate(x => x.BeforeCallToAppLayer(Model, operation));
        }

        public string AfterCallToAppLayer(IOperationModel operation)
        {
            return GetDecorators().Aggregate(x => x.AfterCallToAppLayer(Model, operation));
        }

        public string AfterTransaction(IOperationModel operation)
        {
            return GetDecorators().Aggregate(x => x.AfterTransaction(Model, operation));
        }

        public string OnExceptionCaught(IOperationModel operation)
        {
            var onExceptionCaught = GetDecorators().Aggregate(x => x.OnExceptionCaught(Model, operation));

            if (GetDecorators().Any(x => x.HandlesCaughtException()))
            {
                return onExceptionCaught;
            }

            return onExceptionCaught + @"
                return StatusCode(500, e);";
        }

        public string OnDispose()
        {
            return GetDecorators().Aggregate(x => x.OnDispose(Model));
        }

        public string ClassMethods()
        {
            return GetDecorators().Aggregate(x => x.ClassMethods(Model));
        }

        public IEnumerable<WebApiControllerDecoratorBase> GetDecorators()
        {
            return _decorators ?? (_decorators = Project.ResolveDecorators(this));
        }

        private string GetSecurityAttribute(IOperationModel o)
        {
            if (o.HasStereotype("Secured") || Model.HasStereotype("Secured"))
            {
                var roles = o.GetStereotypeProperty<string>("Secured", "Roles");
                return string.IsNullOrWhiteSpace(roles)
                    ? "[Authorize]" 
                    : $"[Authorize(Roles = \"{roles}\")]";
            }
            return "[AllowAnonymous]";
        }

        private string GetOperationParameters(IOperationModel operation)
        {
            if (!operation.Parameters.Any())
            {
                return string.Empty;
            }
            var verb = GetHttpVerb(operation);
            switch (verb)
            {
                case HttpVerb.POST:
                case HttpVerb.PUT:
                    return operation.Parameters.Select(x => $"{GetParameterBindingAttribute(operation, x)}{GetTypeName(x.TypeReference)} {x.Name}").Aggregate((x, y) => $"{x}, {y}");
                case HttpVerb.GET:
                case HttpVerb.DELETE:
                    if (operation.Parameters.Any(x => x.TypeReference.Type == ReferenceType.ClassType))
                    {
                        Logging.Log.Warning($@"Intent.AspNetCore.WebApi: [{Model.Name}.{operation.Name}] Passing objects into HTTP {GetHttpVerb(operation)} operations is not well supported by this module.
    We recommend using a POST or PUT verb");
                        // Log warning
                    }
                    return operation.Parameters.Select(x => $"{GetTypeName(x.TypeReference)} {x.Name}").Aggregate((x, y) => x + ", " + y);
                default:
                    throw new NotSupportedException($"{verb} not supported");
            }
        }

        private string GetOperationCallParameters(IOperationModel operation)
        {
            if (!operation.Parameters.Any())
            {
                return string.Empty;
            }

            var verb = GetHttpVerb(operation);
            switch (verb)
            {
                case HttpVerb.POST:
                case HttpVerb.PUT:
                case HttpVerb.GET:
                case HttpVerb.DELETE:
                    return operation.Parameters.Select(x => x.Name).Aggregate((x, y) => $"{x}, {y}");
                default:
                    throw new NotSupportedException($"{verb} not supported");
            }
        }

        private string GetOperationReturnType(IOperationModel operation)
        {
            if (operation.ReturnType == null)
            {
                return "void";
            }
            return GetTypeName(operation.ReturnType.TypeReference);
        }

        private HttpVerb GetHttpVerb(IOperationModel operation)
        {
            var verb = operation.GetStereotypeProperty("Http", "Verb", "AUTO").ToUpper();
            if (verb != "AUTO")
            {
                return Enum.TryParse(verb, out HttpVerb verbEnum) ? verbEnum : HttpVerb.POST;
            }
            if (operation.ReturnType == null || operation.Parameters.Any(x => x.TypeReference.Type == ReferenceType.ClassType))
            {
                var hasIdParam = operation.Parameters.Any(x => x.Name.ToLower().EndsWith("id") && x.TypeReference.Type != ReferenceType.ClassType);
                if (hasIdParam && new[] {"delete", "remove"}.Any(x => operation.Name.ToLower().Contains(x)))
                {
                    return HttpVerb.DELETE;
                }
                return hasIdParam ? HttpVerb.PUT : HttpVerb.POST;
            }
            return HttpVerb.GET;
        }

        private string GetPath(IOperationModel operation)
        {
            var path = operation.GetStereotypeProperty<string>("Http", "Route")?.ToLower();
            return path ?? operation.Name.ToLower();
        }

        private string GetParameterBindingAttribute(IOperationModel operation, IOperationParameterModel parameter)
        {
            const string ParameterBinding = "Parameter Binding";
            const string PropertyType = "Type";
            const string PropertyCustomType = "Custom Type";
            const string CustomValue = "Custom";

            if (parameter.HasStereotype(ParameterBinding))
            {
                var attributeName = parameter.GetStereotypeProperty<string>(ParameterBinding, PropertyType);
                if(string.Equals(attributeName, CustomValue, StringComparison.OrdinalIgnoreCase))
                {
                    var customAttributeValue = parameter.GetStereotypeProperty<string>(ParameterBinding, PropertyCustomType);
                    if(string.IsNullOrWhiteSpace(customAttributeValue))
                    {
                        throw new Exception("Parameter Binding was set to custom but no Custom attribute type was specified");
                    }
                    return $"[{customAttributeValue}]";
                }
                return $"[{attributeName}]";
            }

            if (operation.Parameters.Count(p => p.TypeReference.Type == ReferenceType.ClassType) == 1 
                && parameter.TypeReference.Type == ReferenceType.ClassType)
            {
                return "[FromBody]";
            }
            return string.Empty;
        }
    }

    internal enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
