﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.SoftwareFactory.VSProjects.Templates.VisualStudio2015Solution
{
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class VisualStudio2015SolutionTemplate : VisualStudio2015SolutionTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("  \r\n");
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"


            
            #line default
            #line hidden
            this.Write("Microsoft Visual Studio Solution File, Format Version 12.00\r\n# Visual Studio 14\r\n" +
                    "VisualStudioVersion = 14.0.25420.1\r\nMinimumVisualStudioVersion = 10.0.40219.1\r\n");
            
            #line 19 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
  foreach(var project in Projects)
    {
            
            #line default
            #line hidden
            this.Write("Project(\"{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}\") = \"");
            
            #line 21 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectName));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 21 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectName));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 21 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectName));
            
            #line default
            #line hidden
            this.Write(".csproj\", \"{");
            
            #line 21 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("}\"\r\nEndProject\r\n");
            
            #line 23 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
    } 
            
            #line default
            #line hidden
            
            #line 24 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
    foreach(var solutionFolder in SolutionFolders)
    { 

            
            #line default
            #line hidden
            this.Write("Project(\"{2150E333-8FDC-42A3-9474-1A3956D46DE8}\") = \"");
            
            #line 27 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(solutionFolder.FolderName));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 27 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(solutionFolder.FolderName));
            
            #line default
            #line hidden
            this.Write("\", \"{");
            
            #line 27 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(solutionFolder.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("}\"\r\nEndProject\r\n");
            
            #line 29 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
    } 
            
            #line default
            #line hidden
            this.Write("Global\r\n\tGlobalSection(SolutionConfigurationPlatforms) = preSolution\r\n\t\tDebug|Any" +
                    " CPU = Debug|Any CPU\r\n\t\tRelease|Any CPU = Release|Any CPU\r\n\tEndGlobalSection\r\n\tG" +
                    "lobalSection(ProjectConfigurationPlatforms) = postSolution\r\n");
            
            #line 36 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
    foreach(var project in Projects)
    {
            
            #line default
            #line hidden
            this.Write("\t\t{");
            
            #line 38 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("}.Debug|Any CPU.ActiveCfg = Debug|Any CPU\r\n\t\t{");
            
            #line 39 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("}.Debug|Any CPU.Build.0 = Debug|Any CPU\r\n\t\t{");
            
            #line 40 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("}.Release|Any CPU.ActiveCfg = Release|Any CPU\r\n\t\t{");
            
            #line 41 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("}.Release|Any CPU.Build.0 = Release|Any CPU\r\n");
            
            #line 42 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
    } 
            
            #line default
            #line hidden
            this.Write("\tEndGlobalSection\r\n\tGlobalSection(SolutionProperties) = preSolution\r\n\t\tHideSoluti" +
                    "onNode = FALSE\r\n\tEndGlobalSection\r\n\tGlobalSection(NestedProjects) = preSolution\r" +
                    "\n");
            
            #line 48 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
    foreach(var solutionFolder in SolutionFolders)
    { 
        foreach(var associatedProject in solutionFolder.AssociatedProjects)
        {

            
            #line default
            #line hidden
            this.Write("\t\t{");
            
            #line 53 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(associatedProject.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("} = {");
            
            #line 53 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(solutionFolder.Id.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("}\r\n");
            
            #line 54 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.SoftwareFactory.VSProjects\Templates\VisualStudio2015Solution\VisualStudio2015SolutionTemplate.tt"
        }
    } 
            
            #line default
            #line hidden
            this.Write("\tEndGlobalSection\r\nEndGlobal");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class VisualStudio2015SolutionTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
