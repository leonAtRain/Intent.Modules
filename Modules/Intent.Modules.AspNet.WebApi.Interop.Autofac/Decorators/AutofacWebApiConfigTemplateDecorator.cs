﻿using Intent.Modules.AspNet.WebApi.Templates.OwinWebApiConfig;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;
using System;
using System.Collections.Generic;
using Intent.Modules.Autofac.Templates.AutofacConfig;
using Intent.SoftwareFactory.Engine;

namespace Intent.Modules.AspNet.WebApi.Interop.Autofac.Decorators
{
    public class AutofacWebApiConfigTemplateDecorator : IWebApiConfigTemplateDecorator, IHasNugetDependencies, IDeclareUsings
    {
        private readonly IApplication _application;

        public AutofacWebApiConfigTemplateDecorator(IApplication application)
        {
            _application = application;
        }

        public const string Id = "Intent.AspNet.WebApi.Interop.Autofac.WebApiConfigDecorator";

        public IEnumerable<string> Configure()
        {
            return new[]
            {
                "// Autofac",
                "config.DependencyResolver = new AutofacWebApiDependencyResolver(AutofacConfig.GetConfiguredContainer());",
                "app.UseAutofacMiddleware(AutofacConfig.GetConfiguredContainer());",
                "app.UseAutofacWebApi(config);",
        };
        }

        public IEnumerable<string> DeclareUsings()
        {
            return new[]
            {
                "Autofac.Integration.WebApi",
                _application.FindTemplateInstance<IHasClassDetails>(AutofacConfigTemplate.Identifier).Namespace
            };
        }

        public IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[] 
            {
                NugetPackages.AutofacWebApi2Owin
            };
        }
    }
}
