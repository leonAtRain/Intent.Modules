﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.RichDomain.EntityFramework.Templates.RepositoryContract
{
    using Intent.SoftwareFactory.MetaModels.UMLModel;
    using Intent.Modules.RichDomain;
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.RichDomain.EntityFramework\Templates\RepositoryContract\RepositoryContractTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class RepositoryContractTemplate : IntentRoslynProjectItemTemplateBase<Class>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\nusing Intent.Framework.Domain.Repositories;\r\n");
            
            #line 16 "C:\Dev\Intent.Modules\Modules\Intent.Modules.RichDomain.EntityFramework\Templates\RepositoryContract\RepositoryContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Ignore)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.RichDomain.EntityFramework\Templates\RepositoryContract\RepositoryContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [IntentManaged(Mode.Merge)]\r\n    public interface I");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.RichDomain.EntityFramework\Templates\RepositoryContract\RepositoryContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write("Repository : IRepository<I");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.RichDomain.EntityFramework\Templates\RepositoryContract\RepositoryContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.RichDomain.EntityFramework\Templates\RepositoryContract\RepositoryContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 23 "C:\Dev\Intent.Modules\Modules\Intent.Modules.RichDomain.EntityFramework\Templates\RepositoryContract\RepositoryContractTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.IdentifierType()));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
