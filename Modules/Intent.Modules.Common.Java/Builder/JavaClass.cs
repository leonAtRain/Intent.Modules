﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Intent.Modules.Common.Java.Builder;

public class JavaClass : JavaDeclaration<JavaClass>, ICodeBlock
{
    private JavaCodeSeparatorType _propertiesSeparator = JavaCodeSeparatorType.NewLine;
    private JavaCodeSeparatorType _fieldsSeparator = JavaCodeSeparatorType.NewLine;
    
    public JavaClass(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Cannot be null or empty", nameof(name));
        }

        Name = name;
    }
    public JavaCodeSeparatorType BeforeSeparator { get; set; }
    public JavaCodeSeparatorType AfterSeparator { get; set; }

    
    public string Name { get; }
    protected string AccessModifier { get; private set; } = "public ";
    public JavaClass BaseType { get; set; }
    public IList<string> Interfaces { get; } = new List<string>();
    public IList<JavaField> Fields { get; } = new List<JavaField>();
    public IList<JavaConstructor> Constructors { get; } = new List<JavaConstructor>();
    public IList<JavaClassMethod> Methods { get; } = new List<JavaClassMethod>();
    
    public bool IsFinal { get; set; }
    public bool IsAbstract { get; set; }
    
    public JavaClass WithBaseType(string type)
    {
        return ExtendsClass(type);
    }

    public JavaClass WithBaseType(JavaClass type)
    {
        return ExtendsClass(type);
    }

    public JavaClass ExtendsClass(string type)
    {
        BaseType = new JavaClass(type);
        return this;
    }

    public JavaClass ExtendsClass(JavaClass @class)
    {
        BaseType = @class;
        return this;
    }
    
    public JavaClass ImplementsInterface(string type)
    {
        Interfaces.Add(type);
        return this;
    }

    public JavaClass ImplementsInterfaces(IEnumerable<string> types)
    {
        foreach (var type in types)
            Interfaces.Add(type);

        return this;
    }
    
    public JavaClass AddField(string type, string name, Action<JavaField> configure = null)
    {
        var field = new JavaField(type, name)
        {
            BeforeSeparator = _fieldsSeparator,
            AfterSeparator = _fieldsSeparator
        };
        Fields.Add(field);
        configure?.Invoke(field);
        return this;
    }
    
    public JavaClass AddConstructor(Action<JavaConstructor> configure = null)
    {
        var ctor = new JavaConstructor(this);
        Constructors.Add(ctor);
        configure?.Invoke(ctor);
        return this;
    }
    
    public JavaClass AddMethod(string returnType, string name, Action<JavaClassMethod> configure = null)
    {
        return InsertMethod(Methods.Count, returnType, name, configure);
    }
    
    public JavaClass InsertMethod(int index, string returnType, string name, Action<JavaClassMethod> configure = null)
    {
        var method = new JavaClassMethod(returnType, name);
        Methods.Insert(index, method);
        configure?.Invoke(method);
        return this;
    }
    
    public JavaClass Protected()
    {
        AccessModifier = "protected ";
        return this;
    }

    public JavaClass Private()
    {
        AccessModifier = "private ";
        return this;
    }

    public JavaClass Final()
    {
        IsFinal = true;
        return this;
    }

    public JavaClass Abstract()
    {
        IsAbstract = true;
        return this;
    }
    
    private string GetBaseTypes()
    {

        return $"{(BaseType != null ? $" extends {BaseType.Name}" : "")}{(Interfaces.Any() ? $" implements {string.Join(", ", Interfaces)}" : "")}";
    }
    
    private string GetMembers(string indentation)
    {
        var codeBlocks = new List<ICodeBlock>();
        codeBlocks.AddRange(Fields);
        codeBlocks.AddRange(Constructors);
        codeBlocks.AddRange(Methods);

        return $@"{string.Join(@"
", codeBlocks.ConcatCode(indentation))}";
    }
    
    public override string ToString()
    {
        return ToString(string.Empty);
    }
    
    public string ToString(string indentation)
    {
        return $@"{GetComments(indentation)}{GetAnnotations(indentation)}{indentation}{AccessModifier}{(IsFinal ? "final " : "")}{(IsAbstract ? "abstract " : "")}class {Name}{GetBaseTypes()} {{{GetMembers($"{indentation}    ")}
{indentation}}}";
    }
    
    public string GetText(string indentation)
    {
        return ToString(indentation);
    }
}