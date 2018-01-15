﻿using System;
using System.Collections.Generic;
using System.Linq;
using Intent.MetaModel.Common;

namespace Intent.SoftwareFactory.MetaData
{
    public static class FolderExtensions
    {
        public static IList<IFolder> GetFolderPath(this IHasFolder model, bool includePackage = true)
        {
            List<IFolder> result = new List<IFolder>();

            var current = model.Folder;
            while (current != null && (includePackage || !current.IsPackage))
            {
                result.Insert(0, current);
                current = current.ParentFolder;
            }
            return result;
        }
    }

    public static class StereotypeExtensions
    {
        public static T GetStereotypeProperty<T>(this IHasStereotypes model, string stereotypeName, string propertyName, T defaultIfNotFound = default(T))
        {
            return model.GetStereotype(stereotypeName).GetProperty(propertyName, defaultIfNotFound);
        }

        public static IStereotype GetStereotype(this IHasStereotypes model, string stereotypeName)
        {
            return model.Stereotypes.FirstOrDefault(x => x.Name == stereotypeName);
        }

        public static T GetProperty<T>(this IStereotype stereotype, string propertyName, T defaultIfNotFound = default(T))
        {
            if (stereotype == null)
            {
                return defaultIfNotFound;
            }
            foreach (var tag in stereotype.Properties)
            {
                if (tag.Key != propertyName || string.IsNullOrWhiteSpace(tag.Value)) continue;

                if (Nullable.GetUnderlyingType(typeof(T)) != null)
                {
                    return (T)Convert.ChangeType(tag.Value, Nullable.GetUnderlyingType(typeof(T)));
                }
                return (T)Convert.ChangeType(tag.Value, typeof(T));
            }
            return defaultIfNotFound;
        }

        public static bool HasStereotype(this IHasStereotypes model, string stereotypeName)
        {
            return model.Stereotypes.Any(x => x.Name == stereotypeName);
        }

        public static IStereotype GetStereotypeInFolders<T>(this T model, string stereotypeName) where T : IHasFolder, IHasStereotypes
        {
            var folder = model.Folder;
            while (folder != null)
            {
                if (folder.HasStereotype(stereotypeName))
                {
                    return folder.GetStereotype(stereotypeName);
                }
                folder = folder.ParentFolder;
            }
            return null;
        }
    }

    //public static class CommonExtensions
    //{
    //    public static string ToPascalCase(this string s)
    //    {
    //        if (string.IsNullOrWhiteSpace(s))
    //        {
    //            return s;
    //        }
    //        if (Char.IsUpper(s[0]))
    //        {
    //            return s;
    //        }
    //        else
    //        {
    //            return Char.ToUpper(s[0]) + s.Substring(1);
    //        }
    //    }

    //    public static string ToCamelCase(this string s)
    //    {
    //        return s.ToCamelCase(true);
    //    }

    //    public static string ToCamelCase(this string s, bool reservedWordEscape)
    //    {
    //        if (string.IsNullOrWhiteSpace(s))
    //        {
    //            return s;
    //        }
    //        string result;
    //        if (Char.IsLower(s[0]))
    //        {
    //            result = s;
    //        }
    //        else
    //        {
    //            result = Char.ToLower(s[0]) + s.Substring(1);
    //        }

    //        if (reservedWordEscape)
    //        {
    //            switch (result)
    //            {
    //                case "class":
    //                case "namespace":
    //                    return "@" + result;
    //            }
    //        }
    //        return result;
    //    }

    //    public static string ToPrivateMember(this string s)
    //    {
    //        if (string.IsNullOrWhiteSpace(s))
    //        {
    //            return s;
    //        }
    //        return "_" + ToCamelCase(s, false);
    //    }
    //}
}