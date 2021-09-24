﻿using System.Collections.Generic;
using System.Linq;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.VisualStudio;
using Intent.Templates;

namespace Intent.Modules.Common.CSharp.Templates
{
    public static class TemplateExtensions
    {
        public static IEnumerable<INugetPackageInfo> GetAllNugetDependencies(this ITemplate template)
        {
            return template.GetAll<IHasNugetDependencies, INugetPackageInfo>((i) => i.GetNugetDependencies());
        }

        public static IEnumerable<IAssemblyReference> GetAllAssemblyDependencies(this ITemplate template)
        {
            return template.GetAll<IHasAssemblyDependencies, IAssemblyReference>((i) => i.GetAssemblyDependencies());
        }

        public static string ToCamelCase(this string s, bool reservedWordEscape)
        {
            var result = s.ToCamelCase();

            if (reservedWordEscape && Common.Templates.CSharp.ReservedWords.Contains(result))
            {
                return $"@{result}";
            }
            return result;
        }

        public static string AsClassName(this string s)
        {
            if (s.StartsWith("I") && s.Length >= 2 && char.IsUpper(s[1]))
            {
                s = s.Substring(1);
            }
            return s.Replace(".", "");
        }

        /// <summary>
        /// Camel-cases input parameter <paramref name="s"/> and prefixes with an underscore.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToPrivateMember(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }
            return "_" + ToCamelCase(s, false);
        }

        public static string ToCSharpNamespace(this string @string)
        {
            @string = @string
                .Replace("#", "Sharp")
                .Replace("&", "And")
                .Replace("(", " ")
                .Replace(")", " ")
                .Replace(",", " ")
                .Replace("[", " ")
                .Replace("]", " ")
                .Replace("{", " ")
                .Replace("}", " ")
                .Replace("/", " ")
                .Replace("\\", " ")
                .Replace("?", " ")
                .Replace("@", " ");

            while (@string.Contains("  "))
            {
                @string = @string.Replace("  ", " ");
            }

            return string.Concat(@string.Split(' ')
                        .Select(x => string.Join("_", x.Split('-').Select(p => p.ToPascalCase())))
                        .Select(x => string.Join(".", x.Split('.').Select(p => p.ToPascalCase()))));
        }

        /// <summary>
        /// Converts <paramref name="string"/> to a valid C# reference type (e.g. removes and disallowed characters).
        /// </summary>
        /// <param name="string"></param>
        /// <returns></returns>
        public static string ToCSharpIdentifier(this string @string)
        {
            if (string.IsNullOrWhiteSpace(@string))
            {
                return string.Empty;
            }

            @string = @string
                .Replace("#", "Sharp")
                .Replace("&", "And")
                .Replace("-", " ")
                .Replace("(", " ")
                .Replace(")", " ")
                .Replace(",", " ")
                .Replace("[", " ")
                .Replace("]", " ")
                .Replace("{", " ")
                .Replace("}", " ")
                .Replace(".", " ")
                .Replace("/", " ")
                .Replace("\\", " ")
                .Replace("?", " ")
                .Replace("@", " ");

            while (@string.Contains("  "))
            {
                @string = @string.Replace("  ", " ");
            }

            if (char.IsNumber(@string[0]))
            {
                @string = $"_{@string}";
            }

            return string.Concat(@string.Split(' ').Select(x => x.ToPascalCase()));
        }
    }

}
