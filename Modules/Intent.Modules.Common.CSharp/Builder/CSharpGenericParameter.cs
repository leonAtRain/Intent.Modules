﻿namespace Intent.Modules.Common.CSharp.Builder;

public class CSharpGenericParameter
{
    public CSharpGenericParameter(string typeName)
    {
        TypeName = typeName;
    }
    
    public string TypeName { get; }
}