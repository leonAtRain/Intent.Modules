### Version 3.6.7

- Added `<tags></tags>` and `<releaseNotes></releaseNotes>` to `imodspec` files by default.
- Manage Dependency Versions for Intent Architect Modules and nuget packages in C# projects used to build Modules.

### Version 3.6.6
- Fixed : Fixed an issue around `File Template`s crashing the Software Factory.

### Version 3.6.4

- Added support for Templates to target Type-Definition model types. Will respect `C#` stereotype's `Namespace` setting.
- Updated version of `Intent.SoftwareFactory.SDK` NuGet package to install from `3.4.1` to `3.4.2`.

### Version 3.6.3

- Updated dependencies and supported client versions to prevent warnings when used with Intent Architect 4.x.

### Version 3.6.2

- Updated module depenencies to prevent Software Factory warnings of possibly incompatible modules.

### Version 3.6.1

- Nuget Version bumps to align with `Domain Designer`
- Fixed : `ModuleSettingsExtensionsTemplate` was missing a Nuget Dependancy on `Intent.Common`.

### Version 3.6.0

- TemplateExtensions now use `IIntentTemplate` as extension base instead of `IntentTemplateBase`.
- Support for association ends to have Script Options in their context menus.

### Version 3.5.0

- Fixed: Fixed: Static content template `readme.txt` files would be deleted on subsequent software factory runs.
- Fixed: Removed possible legacy hook-in point for something more appropriate.
- New: Added Extension method for checking if a `IPackage` is a certain Model type.
- `ApiPackageExtensionModelTemplate` will not run unless it has at least one method to generate.
- `ApiPackageExtensionModelTemplate` will add NuGet dependencies of extended packages if available.

### Version 3.4.1

- Feature: Support for explicit Element / Association Vision Settings for Diagrams.
- Fixed: Association Extensions applying source-end settings to target-end.

### Version 3.4.0

- Support for Package DefaultNameFunction. Allows the name of a new pacakge to be determined by a script.

### Version 3.3.14

- Default `Templating Method` changed to `String Interpolation` on `File Template`s.

### Version 3.3.13

- Role fields is mandatory of Template Type is not `Custom`.

### Version 3.3.10

- New: `String Interpolation` is now available for `Templating Method` on `File Template`s.
