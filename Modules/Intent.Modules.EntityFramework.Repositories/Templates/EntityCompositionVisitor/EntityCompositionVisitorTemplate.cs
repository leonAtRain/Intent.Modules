﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFramework.Repositories.Templates.EntityCompositionVisitor
{
    using Intent.MetaModel.Domain;
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using Intent.Modules.EntityFramework.Templates;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class EntityCompositionVisitorTemplate : IntentRoslynProjectItemTemplateBase<IEnumerable<IClass>>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n\r\nusing System;\r\nusing Intent.Framework.Core.Visitor;\r\nusing Intent.Framework." +
                    "EntityFramework.Interceptors;\r\nusing System.Collections.Generic;\r\n");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 24 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    /// Determines the entities that are compositionally " +
                    "associated with a root entity.\r\n    /// This is typically used to work out which" +
                    " entities should be deleted when their root is deleted.\r\n    /// </summary>\r\n   " +
                    " public class ");
            
            #line 30 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : IEntityCompositionVisitor\r\n    {\r\n        private readonly IList<object> _enti" +
                    "ties;\r\n\r\n        public ");
            
            #line 34 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"()
        {
            _entities = new List<object>();
        }

        public IList<object> Entities
        {
            get
            {
                return _entities;
            }
        }

        public void Reset()
        {
            _entities.Clear();
        }

        public void Visit(IVisitable visitable)
        {
            Visit((dynamic)visitable);
        }

");
            
            #line 57 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
 foreach (var model in Model) {

            
            #line default
            #line hidden
            this.Write("        public void Visit(");
            
            #line 59 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetClassName(model)));
            
            #line default
            #line hidden
            this.Write(" state)\r\n        {\r\n");
            
            #line 61 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
 
        if (model.ParentClass != null)
        {

            
            #line default
            #line hidden
            this.Write("            Visit((");
            
            #line 65 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetClassName(model.ParentClass)));
            
            #line default
            #line hidden
            this.Write(") state);\r\n");
            
            #line 66 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
 
        }

        foreach(var associationEnd in model.AssociatedClasses)
        {
            if (associationEnd.Association.AssociationType ==  AssociationType.Composition && associationEnd.Association.TargetEnd == associationEnd)
            {
                if (associationEnd.Multiplicity == Multiplicity.Many) {

            
            #line default
            #line hidden
            this.Write("            foreach (IVisitable item in state.");
            
            #line 75 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(")\r\n            {\r\n                item.Accept(this);\r\n            }\r\n");
            
            #line 79 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
              }
                else
                {
            
            #line default
            #line hidden
            this.Write("            if (state.");
            
            #line 82 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name()));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n            {\r\n                ((IVisitable)state.");
            
            #line 84 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associationEnd.Name().ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(").Accept(this);\r\n            }\r\n");
            
            #line 86 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
                }
            }
        }

            
            #line default
            #line hidden
            this.Write("            _entities.Add(state);\r\n        }\r\n\r\n");
            
            #line 93 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\EntityCompositionVisitor\EntityCompositionVisitorTemplate.tt"
 }
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
