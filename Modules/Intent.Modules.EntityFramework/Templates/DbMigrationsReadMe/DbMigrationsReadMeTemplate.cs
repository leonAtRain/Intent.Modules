﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFramework.Templates.DbMigrationsReadMe
{
    using Intent.Modules.Common.Templates;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class DbMigrationsReadMeTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("Create a new migration:\r\n--------------------------------------------------------" +
                    "--------------------------------------------------------------------------------" +
                    "---------------\r\nadd-migration -Name {ChangeName} -StartupProjectName \"");
            
            #line 6 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ProjectWithDbContext));
            
            #line default
            #line hidden
            this.Write("\" -ProjectName ");
            
            #line 6 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MigrationProject));
            
            #line default
            #line hidden
            this.Write(" -ConfigurationTypeName ");
            
            #line 6 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextConfigurationName));
            
            #line default
            #line hidden
            this.Write(@"


Override an existing migration:
-------------------------------------------------------------------------------------------------------------------------------------------------------
add-migration -Name {ExistingNameWithoutDateComponent} -StartupProjectName """);
            
            #line 11 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ProjectWithDbContext));
            
            #line default
            #line hidden
            this.Write("\" -ProjectName ");
            
            #line 11 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MigrationProject));
            
            #line default
            #line hidden
            this.Write(" -ConfigurationTypeName ");
            
            #line 11 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextConfigurationName));
            
            #line default
            #line hidden
            this.Write(" -Force\r\n\r\n\r\nUpdate to latest version:\r\n-----------------------------------------" +
                    "--------------------------------------------------------------------------------" +
                    "------------------------------\r\nupdate-database -StartupProjectName \"");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ProjectWithDbContext));
            
            #line default
            #line hidden
            this.Write("\" -ProjectName ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MigrationProject));
            
            #line default
            #line hidden
            this.Write(" -ConfigurationTypeName ");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextConfigurationName));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n\r\nUpgrade/downgrade to specific version\r\n------------------------------------" +
                    "--------------------------------------------------------------------------------" +
                    "-----------------------------------\r\nupdate-database -StartupProjectName \"");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ProjectWithDbContext));
            
            #line default
            #line hidden
            this.Write("\" -ProjectName ");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MigrationProject));
            
            #line default
            #line hidden
            this.Write(" -ConfigurationTypeName ");
            
            #line 21 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextConfigurationName));
            
            #line default
            #line hidden
            this.Write(@" -TargetMigration:{Target}


Generate script which detects current database version and updates it to the latest:
-------------------------------------------------------------------------------------------------------------------------------------------------------
update-database -StartupProjectName """);
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ProjectWithDbContext));
            
            #line default
            #line hidden
            this.Write("\" -ProjectName ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MigrationProject));
            
            #line default
            #line hidden
            this.Write(" -ConfigurationTypeName ");
            
            #line 26 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextConfigurationName));
            
            #line default
            #line hidden
            this.Write(@" -Script -SourceMigration:$InitialDatabase


Generate a script two upgrade from and to a specific version:
-------------------------------------------------------------------------------------------------------------------------------------------------------
update-database -StartupProjectName """);
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ProjectWithDbContext));
            
            #line default
            #line hidden
            this.Write("\" -ProjectName ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(MigrationProject));
            
            #line default
            #line hidden
            this.Write(" -ConfigurationTypeName ");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DbContextConfigurationName));
            
            #line default
            #line hidden
            this.Write(@" -Script -SourceMigration:{Source} -TargetMigration:{Target}


Drop all tables in schema:
-------------------------------------------------------------------------------------------------------------------------------------------------------
DECLARE @SCHEMA AS varchar(max) = '");
            
            #line 36 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework\Templates\DbMigrationsReadMe\DbMigrationsReadMeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BoundedContextName));
            
            #line default
            #line hidden
            this.Write(@"'
DECLARE @EXECUTE_STATEMENT AS varchar(max) = (SELECT STUFF((SELECT CHAR(13) + CHAR(10) + [Statement] FROM (
    SELECT 'ALTER TABLE ['+@SCHEMA+'].['+[t].[name]+'] DROP CONSTRAINT ['+[fk].[name]+']' AS [Statement] FROM [sys].[foreign_keys] AS [fk] INNER JOIN [sys].[tables] AS [t] ON [t].[object_id] = [fk].[parent_object_id] INNER JOIN [sys].[schemas] AS [s] ON [s].[schema_id] = [t].[schema_id] WHERE [s].[name] = @SCHEMA
    UNION ALL
    SELECT 'DROP TABLE ['+@SCHEMA+'].['+[t].[name]+']' AS [Statement] FROM [sys].[tables] AS [t] INNER JOIN [sys].[schemas] AS [s] ON [s].[schema_id] = [t].[schema_id] WHERE [s].[name] = @SCHEMA
) A FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''))
EXECUTE(@EXECUTE_STATEMENT)
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
