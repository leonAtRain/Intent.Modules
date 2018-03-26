using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Intent.Modules.VisualStudio.Projects.Decorators;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;
using Microsoft.Build.Construction;

namespace Intent.Modules.VisualStudio.Projects.Templates.LibraryCSProjectFile
{
    public class LibraryCSProjectFileTemplate : IntentProjectItemTemplateBase<object>, IProjectTemplate, ISupportXmlDecorators, IHasDecorators<ICSProjectFileDecorator>, IHasNugetDependencies
    {
        public const string Identifier = "Intent.VisualStudio.Projects.LibraryCSProjectFile";
        private readonly Dictionary<string, IXmlDecorator> _xmlDecorators = new Dictionary<string, IXmlDecorator>();
        private IEnumerable<ICSProjectFileDecorator> _decorators;

        public LibraryCSProjectFileTemplate(IProject project)
            : base (Identifier, project, null)
        {
        }

        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: Project.Name,
                fileExtension: "csproj",
                defaultLocationInProject: ""
                );
        }

        public override string TransformText()
        {
            var meta = GetMetaData();
            var fullFileName = Path.Combine(meta.GetFullLocationPath(), meta.FileNameWithExtension());

            var doc = LoadOrCreate(fullFileName);
            foreach (var decorator in GetXmlDecorators())
            {
                decorator.Install(doc, Project);
            }
            return doc.ToStringUTF8();
        }

        private XDocument LoadOrCreate(string fullFileName)
        {
            XDocument doc;
            if (File.Exists(fullFileName))
            {
                doc = XDocument.Load(fullFileName);
            }
            else
            {
                doc = XDocument.Parse(CreateTemplate());
            }
            return doc;
        }

        public IEnumerable<ICSProjectFileDecorator> GetDecorators()
        {
            return _decorators ?? (_decorators = Project.ResolveDecorators(this));
        }

        private IEnumerable<IXmlDecorator> GetXmlDecorators()
        {
            return _xmlDecorators.Values.Union(GetDecorators());
        }

        // TODO: ISupportXmlDecorators and GetXmlDecorators probably shouldn't be here, so far as I can see nothing is relying on it
        public void RegisterDecorator(string id, IXmlDecorator decorator)
        {
            if (!_xmlDecorators.ContainsKey(id))
            {
                _xmlDecorators.Add(id, decorator);
            }
        }

        public string CreateTemplate()
        {
            var root = ProjectRootElement.Create();
            root.ToolsVersion = "14.0";
            root.DefaultTargets = "Build";

            var group = root.AddPropertyGroup();
            group.AddProperty("Configuration", "Debug").Condition = " '$(Configuration)' == '' ";
            group.AddProperty("Platform", "AnyCPU").Condition = " '$(Platform)' == '' ";
            group.AddProperty("ProjectGuid", $"{{{Project.Id}}}");
            group.AddProperty("OutputType", "Library");
            group.AddProperty("AppDesignerFolder", "Properties");
            group.AddProperty("RootNamespace", $"{Project.Name}");
            group.AddProperty("AssemblyName", $"{Project.Name}");
            group.AddProperty("TargetFrameworkVersion", Project.TargetFrameworkVersion());
            group.AddProperty("FileAlignment", "512");
            group.AddProperty("TargetFrameworkProfile", "");

            group = root.AddPropertyGroup();
            group.Condition = " '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ";
            group.AddProperty("DebugSymbols", "true");
            group.AddProperty("DebugType", "full");
            group.AddProperty("Optimize", "false");
            group.AddProperty("OutputPath", "bin\\Debug\\");
            group.AddProperty("DefineConstants", "DEBUG;TRACE");
            group.AddProperty("ErrorReport", "prompt");
            group.AddProperty("WarningLevel", "4");

            group = root.AddPropertyGroup();
            group.Condition = " '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ";
            group.AddProperty("DebugType", "pdbonly");
            group.AddProperty("Optimize", "true");
            group.AddProperty("OutputPath", "bin\\Release\\");
            group.AddProperty("DefineConstants", "TRACE");
            group.AddProperty("ErrorReport", "prompt");
            group.AddProperty("WarningLevel", "4");

            var itemGroup = AddItems(root, "Reference", 
                "Microsoft.CSharp"
                , "System"
                , "System.Core"
                , "System.Data.DataSetExtensions"
                , "System.Data"
                , "System.Xml"
                , "System.Xml.Linq");

            foreach (var reference in Project.References())
            {
                AddReference(itemGroup, reference);
            }

            foreach (var dependency in Project.Dependencies())
            {
                AddItem(itemGroup, "ProjectReference", string.Format("..\\{0}\\{0}.csproj", dependency.ProjectName),
                    new[]
                    {
                        new KeyValuePair<string, string>("Project", $"{{{dependency.Id}}}"),
                        new KeyValuePair<string, string>("Name", $"{dependency.ProjectName}"),
                    });
            }

            root.AddImport("$(MSBuildToolsPath)\\Microsoft.CSharp.targets");

            return root.RawXml.Replace("utf-16", "utf-8");
        }

        private static ProjectItemGroupElement AddItems(ProjectRootElement elem, string groupName, params string[] items)
        {
            var group = elem.AddItemGroup();
            foreach (var item in items)
            {
                group.AddItem(groupName, item);
            }
            return group;
        }

        private static void AddItem(ProjectItemGroupElement itemGroup, string groupName, string item, IEnumerable<KeyValuePair<string, string>> metaData)
        {
            itemGroup.AddItem(groupName, item, metaData);
        }

        private void AddReference(ProjectItemGroupElement itemGroup, IAssemblyReference reference)
        {
            var metaData = new List<KeyValuePair<string, string>>();
            if (reference.HasHintPath())
            {
                metaData.Add(new KeyValuePair<string, string>("HintPath", reference.HintPath));
            }
            AddItem(itemGroup, "Reference", reference.Library, metaData);
        }

        public void RegisterDecorator(string id, object decorator)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.IntentFrameworkCore
            };
        }
    }
}