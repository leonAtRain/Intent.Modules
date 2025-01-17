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
    public static class AssociationVisualSettingsModelStereotypeExtensions
    {
        public static Setting GetSetting(this AssociationVisualSettingsModel model)
        {
            var stereotype = model.GetStereotype("Setting");
            return stereotype != null ? new Setting(stereotype) : null;
        }

        public static bool HasSetting(this AssociationVisualSettingsModel model)
        {
            return model.HasStereotype("Setting");
        }

        public static bool TryGetSetting(this AssociationVisualSettingsModel model, out Setting stereotype)
        {
            if (!HasSetting(model))
            {
                stereotype = null;
                return false;
            }

            stereotype = new Setting(model.GetStereotype("Setting"));
            return true;
        }


        public class Setting
        {
            private IStereotype _stereotype;

            public Setting(IStereotype stereotype)
            {
                _stereotype = stereotype;
            }

            public string Name => _stereotype.Name;

            public string LineColor()
            {
                return _stereotype.GetProperty<string>("Line Color");
            }

            public string LineWidth()
            {
                return _stereotype.GetProperty<string>("Line Width");
            }

            public string LineDashArray()
            {
                return _stereotype.GetProperty<string>("Line Dash Array");
            }

        }

    }
}