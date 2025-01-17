using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Modules.Common.CSharp.Templates;

namespace Intent.Modules.Common.CSharp.Builder;

public class CSharpParameter
{
    public string Type { get; }
    public string Name { get; }
    public string DefaultValue { get; private set; }
    public IList<CSharpAttribute> Attributes { get; } = new List<CSharpAttribute>();
    public bool HasThisModifier { get; private set; }

    public CSharpParameter(string type, string name)
    {
        if (string.IsNullOrWhiteSpace(type))
        {
            throw new ArgumentException("Cannot be null or empty", nameof(type));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Cannot be null or empty", nameof(name));
        }

        Type = type;
        Name = name;
    }

    public CSharpParameter AddAttribute(string name, Action<CSharpAttribute> configure = null)
    {
        var param = new CSharpAttribute(name);
        Attributes.Add(param);
        configure?.Invoke(param);
        return this;
    }

    public CSharpParameter WithDefaultValue(string defaultValue)
    {
        DefaultValue = defaultValue;
        return this;
    }

    public CSharpParameter WithThisModifier()
    {
        HasThisModifier = true;
        return this;
    }

    public override string ToString()
    {
        var name = Name.EnsureNotKeyword();
        var modifier = HasThisModifier
            ? "this "
            : string.Empty;
        var defaultValue = DefaultValue != null
            ? $" = {DefaultValue}"
            : string.Empty;

        return $@"{modifier}{GetAttributes()}{Type} {name}{defaultValue}";
    }

    protected string GetAttributes()
    {
        return $@"{(Attributes.Any() ? $@"{string.Join(@" ", Attributes)} " : string.Empty)}";
    }
}