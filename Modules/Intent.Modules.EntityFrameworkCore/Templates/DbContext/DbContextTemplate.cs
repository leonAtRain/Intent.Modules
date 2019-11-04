﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFrameworkCore.Templates.DbContext
{
    using Intent.Modelers.Domain.Api;
    using Intent.Modules.Common.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class DbContextTemplate : IntentRoslynProjectItemTemplateBase<IEnumerable<IClass>>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\nusing Microsoft.EntityFrameworkCore;\r\n");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetBaseClass()));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        public ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(DbContextOptions options) : base(options)\r\n        {\r\n\r\n        }\r\n\r\n");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
 foreach (var model in Model) {
            
            #line default
            #line hidden
            this.Write("        public DbSet<");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetEntityName(model)));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetEntityName(model).ToPluralName()));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 31 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
 }
            
            #line default
            #line hidden
            this.Write("\r\n        protected override void OnModelCreating(ModelBuilder modelBuilder)\r\n   " +
                    "     {\r\n            base.OnModelCreating(modelBuilder);\r\n\r\n            Configure" +
                    "Model(modelBuilder);\r\n\r\n");
            
            #line 39 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
 foreach (var model in Model) {
            
            #line default
            #line hidden
            this.Write("            modelBuilder.ApplyConfiguration(new ");
            
            #line 40 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Mapping());\r\n");
            
            #line 41 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
 }
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        [IntentManaged(Mode.Ignore)]\r\n        private void Configure" +
                    "Model(ModelBuilder modelBuilder)\r\n        {\r\n            // Customize Default Sc" +
                    "hema\r\n            // modelBuilder.HasDefaultSchema(\"");
            
            #line 48 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFrameworkCore\Templates\DbContext\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Project.Application.Name));
            
            #line default
            #line hidden
            this.Write(@""");
            
            // Seed data
            // https://rehansaeed.com/migrating-to-entity-framework-core-seed-data/
            /* Eg.

            modelBuilder.Entity<Car>().HasData(
                new Car() { CarId = 1, Make = ""Ferrari"", Model = ""F40"" },
                new Car() { CarId = 2, Make = ""Ferrari"", Model = ""F50"" },
                new Car() { CarId = 3, Make = ""Labourghini"", Model = ""Countach"" });
            */
        }
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
