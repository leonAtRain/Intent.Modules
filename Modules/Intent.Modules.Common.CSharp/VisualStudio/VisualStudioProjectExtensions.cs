﻿using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Modules.Common.CSharp.VisualStudio;
using Intent.Modules.Constants;
using Intent.SdkEvolutionHelpers;

namespace Intent.Modules.Common.VisualStudio
{
    public static class VisualStudioProjectExtensions
    {
        private const string DEPENDENCIES = "VS.Dependencies";
        private const string NUGET_PACKAGES = "VS.NugetPackages";
        private const string REFERENCES = "VS.References";
        private const string FRAMEWORK_DEPENDENCY = "VS.FrameworkReferences";
        
        public static void InitializeVSMetadata(this IOutputTarget outputTarget)
        {
            outputTarget.Metadata[NUGET_PACKAGES] = new List<INugetPackageInfo>();
            outputTarget.Metadata[DEPENDENCIES] = new List<IOutputTarget>();
            outputTarget.Metadata[REFERENCES] = new List<IAssemblyReference>();
            outputTarget.Metadata[FRAMEWORK_DEPENDENCY] = new HashSet<string>();
        }

        public static void AddFrameworkDependency(this IOutputTarget outputTarget, string frameworkDependency)
        {
            ((HashSet<string>)outputTarget.Metadata[FRAMEWORK_DEPENDENCY]).Add(frameworkDependency);
        }

        public static IEnumerable<string> FrameworkDependencies(this IOutputTarget outputTarget)
        {
            return ((HashSet<string>)outputTarget.Metadata[FRAMEWORK_DEPENDENCY]).OrderBy(x => x).ToArray();
        }

        public static IList<IOutputTarget> Dependencies(this IOutputTarget outputTarget)
        {
            return outputTarget.Metadata[DEPENDENCIES] as IList<IOutputTarget>;
        }

        public static void AddDependency(this IOutputTarget outputTarget, IOutputTarget dependency)
        {
            if (outputTarget.Equals(dependency))
            {
                throw new Exception($"OutputTarget [{outputTarget}] cannot add a dependency to itself");
            }
            var collection = outputTarget.Dependencies();
            if (!collection.Contains(dependency))
            {
                collection.Add(dependency);
            }
        }

        /// <summary>
        /// Obsolete. Use <see cref="OutputTargetExtensions.AddNugetPackages(ICSharpProject,IEnumerable{INugetPackageInfo})"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        public static void AddNugetPackages(this IOutputTarget outputTarget, IEnumerable<INugetPackageInfo> packages)
        {
            var collection = outputTarget.NugetPackages();
            collection.AddRange(packages);
        }

        public static void AddReference(this IOutputTarget outputTarget, IAssemblyReference assemblyDependency)
        {
            var collection = outputTarget.References();
            if (!collection.Contains(assemblyDependency))
                collection.Add(assemblyDependency);
        }

        public static bool IsVSProject(this IOutputTarget outputTarget)
        {
            return new[] {
                    VisualStudioProjectTypeIds.CSharpLibrary,
                    VisualStudioProjectTypeIds.WebApiApplication,
                    VisualStudioProjectTypeIds.WcfApplication,
                    VisualStudioProjectTypeIds.ConsoleAppNetFramework,
                    VisualStudioProjectTypeIds.NodeJsConsoleApplication,
                    VisualStudioProjectTypeIds.CoreWebApp,
                    VisualStudioProjectTypeIds.CoreCSharpLibrary,
                    VisualStudioProjectTypeIds.SQLServerDatabaseProject,
                    VisualStudioProjectTypeIds.AzureFunctionsProject,
                    VisualStudioProjectTypeIds.CoreConsoleApp
            }.Contains(outputTarget.Type);
        }

        public static List<INugetPackageInfo> NugetPackages(this IOutputTarget outputTarget)
        {
            if (outputTarget.Metadata.TryGetValue(NUGET_PACKAGES, out var value) &&
                value is List<INugetPackageInfo> nugetPackages)
            {
                return nugetPackages;
            }

            return new List<INugetPackageInfo>();
        }

        public static IList<IAssemblyReference> References(this IOutputTarget outputTarget)
        {
            return outputTarget.Metadata[REFERENCES] as IList<IAssemblyReference>;
        }

        public static string TargetFramework(this IOutputTarget outputTarget)
        {
            var targetFramework = outputTarget.GetSupportedFrameworks().FirstOrDefault();
            return targetFramework ?? "netcoreapp2.1";
        }

        public static bool IsNetCore2App(this IOutputTarget outputTarget)
        {
            return outputTarget.GetSupportedFrameworks().Any(x => x.StartsWith("netcoreapp2"));
        }

        public static bool IsNetCore3App(this IOutputTarget outputTarget)
        {
            return outputTarget.GetSupportedFrameworks().Any(x => x.StartsWith("netcoreapp3"));
        }

        /// <summary>
        /// Obsolete. Use <see cref="IsNetApp"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        public static bool IsNet5App(this IOutputTarget outputTarget) => outputTarget.IsNetApp(5);

        /// <summary>
        /// Obsolete. Use <see cref="IsNetApp"/> instead.
        /// </summary>
        [Obsolete(WillBeRemovedIn.Version4)]
        public static bool IsNet6App(this IOutputTarget outputTarget) => outputTarget.IsNetApp(6);

        public static bool IsNetApp(this IOutputTarget outputTarget, byte version)
        {
            var startsWith = $"net{version:D}";
            return outputTarget.GetSupportedFrameworks().Any(x => x.StartsWith(startsWith));
        }
    }
}
