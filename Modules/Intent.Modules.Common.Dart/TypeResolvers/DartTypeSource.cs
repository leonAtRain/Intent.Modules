﻿using System;
using Intent.Engine;
using Intent.Modules.Common.TypeResolution;


namespace Intent.Modules.Common.Dart.TypeResolvers
{
    public class DartTypeSource
    {
        public static ITypeSource Create(ISoftwareFactoryExecutionContext context, string templateId)
        {
            return Create(context, templateId, (ICollectionFormatter)null);
        }

        public static ITypeSource Create(ISoftwareFactoryExecutionContext context, string templateId, string collectionFormat)
        {
            return Create(context, templateId, CollectionFormatter.Create(collectionFormat));
        }

        public static ITypeSource Create(ISoftwareFactoryExecutionContext context, string templateId, ICollectionFormatter collectionFormatter)
        {
            return ClassTypeSource.Create(context, templateId).WithCollectionFormatter(collectionFormatter);
        }
    }
}

