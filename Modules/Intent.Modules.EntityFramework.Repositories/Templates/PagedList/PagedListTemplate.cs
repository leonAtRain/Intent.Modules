﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.EntityFramework.Repositories.Templates.PagedList
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class PagedListTemplate : IntentRoslynProjectItemTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("using System.Collections.Generic;\r\nusing System.Data.Entity;\r\nusing System.Linq;\r" +
                    "\nusing System.Threading.Tasks;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n" +
                    "\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("<T> : List<T>, ");
            
            #line 22 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PagedResultInterfaceName));
            
            #line default
            #line hidden
            this.Write("<T>\r\n    {\r\n        public int TotalCount { get; private set; }\r\n        public i" +
                    "nt PageCount { get; private set; }\r\n        public int PageNo { get; private set" +
                    "; }\r\n        public int PageSize { get; private set; }\r\n\r\n        public ");
            
            #line 29 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(IQueryable<T> source, int pageNo, int pageSize)
        {
            TotalCount = source.Count();
            PageCount = GetPageCount(pageSize, TotalCount);
            PageNo = pageNo;
            PageSize = pageSize;
            var skip = ((PageNo - 1) * PageSize);

            AddRange(source
                .Skip(skip)
                .Take(PageSize)
                .ToList());
        }

        public ");
            
            #line 43 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"(int totalCount, int pageNo, int pageSize, List<T> results)
        {
            TotalCount = totalCount;
            PageCount = GetPageCount(pageSize, TotalCount);
            PageNo = pageNo;
            PageSize = pageSize;
            AddRange(results);
        }

        public static async Task<");
            
            #line 52 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PagedResultInterfaceName));
            
            #line default
            #line hidden
            this.Write(@"<T>> CreateAsync(IQueryable<T> source, int pageNo, int pageSize)
        {
            var count = await source.CountAsync();
            var skip = ((pageNo - 1) * pageSize);
            var results = await source
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();
            return new ");
            
            #line 60 "C:\Dev\Intent.Modules\Modules\Intent.Modules.EntityFramework.Repositories\Templates\PagedList\PagedListTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(@"<T>(totalCount: count, pageNo: pageNo, pageSize: pageSize, results: results);
        }

        private int GetPageCount(int pageSize, int totalCount)
        {
            if (pageSize == 0)
                return 0;

            var remainder = totalCount % pageSize;
            return (totalCount / pageSize) + (remainder == 0 ? 0 : 1);
        }
    }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
