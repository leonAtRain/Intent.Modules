﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AngularJs.Templates.State
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs\Templates\State\AngularJsStateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class AngularJsStateTemplate : IntentTypescriptProjectItemTemplateBase<ViewStateModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs\Templates\State\AngularJsStateTemplate.tt"




            
            #line default
            #line hidden
            this.Write(@"'use strict';
namespace App {
    export class ShellStateManager implements ng.ui.IState {
		static state = () => <ng.ui.IState>{
            url: ""/"",
            templateUrl: ""App/Shell/ShellView.html"",
            resolve: {
				viewModel: [""ShellStateManager"",
					(manager: ShellStateManager) => {
						return new ShellViewModel();
					}
				]
            },
            controller: [
                ""$scope"", ""viewModel"", ($scope: ng.IScope, viewModel: IViewModel) => {
                    (<any>$scope).vm = viewModel;
                    $scope.$on(""$destroy"", () => viewModel.dispose());
                }
            ]
        };

        static $inject = [];
        constructor() { 
        }
    }

    angular.module(""App"").service(""ShellStateManager"", ShellStateManager);
}");
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
}
