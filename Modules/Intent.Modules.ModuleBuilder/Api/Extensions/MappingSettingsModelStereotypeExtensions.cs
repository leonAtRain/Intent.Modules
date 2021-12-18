using System;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModelExtensions", Version = "1.0")]

namespace Intent.ModuleBuilder.Api
{
    public static class MappingSettingsModelStereotypeExtensions
    {
        public static MappingSettings GetMappingSettings(this MappingSettingsModel model)
        {
            var stereotype = model.GetStereotype("Mapping Settings");
            return stereotype != null ? new MappingSettings(stereotype) : null;
        }

        public static bool HasMappingSettings(this MappingSettingsModel model)
        {
            return model.HasStereotype("Mapping Settings");
        }


        public class MappingSettings
        {
            private IStereotype _stereotype;

            public MappingSettings(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string Shortcut()
            {
                return _stereotype.GetProperty<string>("Shortcut");
            }

            public IElement DefaultDesigner()
            {
                return _stereotype.GetProperty<IElement>("Default Designer");
            }

            public OptionSourceOptions OptionSource()
            {
                return new OptionSourceOptions(_stereotype.GetProperty<string>("Option Source"));
            }

            public string LookupElementFunction()
            {
                return _stereotype.GetProperty<string>("Lookup Element Function");
            }

            public IElement[] LookupTypes()
            {
                return _stereotype.GetProperty<IElement[]>("Lookup Types") ?? new IElement[0];
            }

            public MapFromOptions MapFrom()
            {
                return new MapFromOptions(_stereotype.GetProperty<string>("Map From"));
            }

            public bool AutoSyncTypeReferences()
            {
                return _stereotype.GetProperty<bool>("Auto-sync Type References");
            }

            public string Symbol()
            {
                return _stereotype.GetProperty<string>("Symbol");
            }

            public string Style()
            {
                return _stereotype.GetProperty<string>("Style");
            }

            public class OptionSourceOptions
            {
                public readonly string Value;

                public OptionSourceOptions(string value)
                {
                    Value = value;
                }

                public OptionSourceOptionsEnum AsEnum()
                {
                    switch (Value)
                    {
                        case "Elements of Type":
                            return OptionSourceOptionsEnum.ElementsOfType;
                        case "Lookup Element":
                            return OptionSourceOptionsEnum.LookupElement;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                public bool IsElementsOfType()
                {
                    return Value == "Elements of Type";
                }
                public bool IsLookupElement()
                {
                    return Value == "Lookup Element";
                }
            }

            public enum OptionSourceOptionsEnum
            {
                ElementsOfType,
                LookupElement
            }
            public class MapFromOptions
            {
                public readonly string Value;

                public MapFromOptions(string value)
                {
                    Value = value;
                }

                public MapFromOptionsEnum AsEnum()
                {
                    switch (Value)
                    {
                        case "Root Element":
                            return MapFromOptionsEnum.RootElement;
                        case "Child Elements":
                            return MapFromOptionsEnum.ChildElements;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                public bool IsRootElement()
                {
                    return Value == "Root Element";
                }
                public bool IsChildElements()
                {
                    return Value == "Child Elements";
                }
            }

            public enum MapFromOptionsEnum
            {
                RootElement,
                ChildElements
            }
        }

    }
}