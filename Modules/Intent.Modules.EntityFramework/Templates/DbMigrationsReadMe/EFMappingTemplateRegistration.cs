﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Intent.MetaModel.Domain;
using Intent.Modules.Common.Registrations;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.Templates.Registrations;

namespace Intent.Modules.EntityFramework.Templates.DbMigrationsReadMe
{
    [Description(DbMigrationsReadMeTemplate.Identifier)]
    public class DbMigrationsReadMeTemplateRegistration : NoModelTemplateRegistrationBase
    {
        public override string TemplateId => DbMigrationsReadMeTemplate.Identifier;

        public override ITemplate CreateTemplateInstance(IProject project)
        {
            return new DbMigrationsReadMeTemplate(project);
        }
    }
}
