using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.Api.ApiElementModelExtensions", Version = "1.0")]

namespace Intent.ModuleBuilder.Api
{
    public static class CoreTypeModelStereotypeExtensions
    {
        public static Settings GetSettings(this CoreTypeModel model)
        {
            var stereotype = model.GetStereotype("Settings");
            return stereotype != null ? new Settings(stereotype) : null;
        }

        public static bool HasSettings(this CoreTypeModel model)
        {
            return model.HasStereotype("Settings");
        }

        public static bool TryGetSettings(this CoreTypeModel model, out Settings stereotype)
        {
            if (!HasSettings(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new Settings(model.GetStereotype("Settings"));
            return true;
        }


        public class Settings
        {
            private IStereotype _stereotype;

            public Settings(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public SaveModeOptions SaveMode()
            {
                return new SaveModeOptions(_stereotype.GetProperty<string>("Save Mode"));
            }

            public IIconModel Icon()
            {
                return _stereotype.GetProperty<IIconModel>("Icon");
            }

            public IIconModel ExpandedIcon()
            {
                return _stereotype.GetProperty<IIconModel>("Expanded Icon");
            }

            public string IconFunction()
            {
                return _stereotype.GetProperty<string>("Icon Function");
            }

            public string DisplayTextFunction()
            {
                return _stereotype.GetProperty<string>("Display Text Function");
            }

            public string ValidateFunction()
            {
                return _stereotype.GetProperty<string>("Validate Function");
            }

            public bool AllowRename()
            {
                return _stereotype.GetProperty<bool>("Allow Rename");
            }

            public bool AllowAbstract()
            {
                return _stereotype.GetProperty<bool>("Allow Abstract");
            }

            public bool AllowSetValue()
            {
                return _stereotype.GetProperty<bool>("Allow Set Value");
            }

            public bool AllowGenericTypes()
            {
                return _stereotype.GetProperty<bool>("Allow Generic Types");
            }

            public bool AllowSorting()
            {
                return _stereotype.GetProperty<bool>("Allow Sorting");
            }

            public SortChildrenOptions SortChildren()
            {
                return new SortChildrenOptions(_stereotype.GetProperty<string>("Sort Children"));
            }

            public bool AllowFindInView()
            {
                return _stereotype.GetProperty<bool>("Allow Find in View");
            }

            public class SaveModeOptions
            {
                public readonly string Value;

                public SaveModeOptions(string value)
                {
                    Value = value;
                }

                public SaveModeOptionsEnum AsEnum()
                {
                    switch (Value)
                    {
                        case "Default":
                            return SaveModeOptionsEnum.Default;
                        case "Own File":
                            return SaveModeOptionsEnum.OwnFile;
                        case "As Child":
                            return SaveModeOptionsEnum.AsChild;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                public bool IsDefault()
                {
                    return Value == "Default";
                }
                public bool IsOwnFile()
                {
                    return Value == "Own File";
                }
                public bool IsAsChild()
                {
                    return Value == "As Child";
                }
            }

            public enum SaveModeOptionsEnum
            {
                Default,
                OwnFile,
                AsChild
            }
            public class SortChildrenOptions
            {
                public readonly string Value;

                public SortChildrenOptions(string value)
                {
                    Value = value;
                }

                public SortChildrenOptionsEnum AsEnum()
                {
                    switch (Value)
                    {
                        case "Manually":
                            return SortChildrenOptionsEnum.Manually;
                        case "By type then manually":
                            return SortChildrenOptionsEnum.ByTypeThenManually;
                        case "By type then name":
                            return SortChildrenOptionsEnum.ByTypeThenName;
                        case "By name":
                            return SortChildrenOptionsEnum.ByName;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                public bool IsManually()
                {
                    return Value == "Manually";
                }
                public bool IsByTypeThenManually()
                {
                    return Value == "By type then manually";
                }
                public bool IsByTypeThenName()
                {
                    return Value == "By type then name";
                }
                public bool IsByName()
                {
                    return Value == "By name";
                }
            }

            public enum SortChildrenOptionsEnum
            {
                Manually,
                ByTypeThenManually,
                ByTypeThenName,
                ByName
            }
        }

    }
}