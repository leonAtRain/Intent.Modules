﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AngularJs.Auth.ImplicitAuth.Templates.LoginCallbackState
{
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
    
    #line 1 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\LoginCallbackState\LoginCallbackStateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class LoginCallbackStateTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent.Modules\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\LoginCallbackState\LoginCallbackStateTemplate.tt"




            
            #line default
            #line hidden
            this.Write("\'use strict\';\r\nnamespace App.Auth {\r\n    export class LoginCallbackState implemen" +
                    "ts ng.ui.IState {\r\n        url = \"/login-callback/{response}\";\r\n        data = {" +
                    "\r\n            allowAnonymous: true\r\n        };\r\n        templateUrl = \"/App/Auth" +
                    "/LoginCallback/LoginCallback.html\";\r\n        resolve = {\r\n            viewModel:" +
                    " () => { return {}; },\r\n            processToken: [\"$stateParams\", \"$rootScope\"," +
                    " \"$state\", \"OidcTokenManager\", \"UserInfoService\", \"localStorageService\", \"viewMo" +
                    "del\", (\r\n                $stateParams: any,\r\n                $rootScope: ng.IRoo" +
                    "tScopeService,\r\n                $state: ng.ui.IStateService,\r\n                oi" +
                    "dcTokenManager: Oidc.OidcTokenManager,\r\n                userInfoService: UserInf" +
                    "oService,\r\n                localStorage: ng.local.storage.ILocalStorageService,\r" +
                    "\n                viewModel: any) => {\r\n\r\n                var hash = $stateParams" +
                    ".response;\r\n                if (hash.charAt(0) === \"&\") {\r\n                    h" +
                    "ash = hash.substr(1);\r\n                }\r\n\r\n                oidcTokenManager.pro" +
                    "cessTokenCallbackAsync(hash).then(() => {\r\n                    userInfoService.l" +
                    "oadFromProfile(oidcTokenManager.profile);\r\n                    $state.go(localSt" +
                    "orage.get(\"login-return-state\"), localStorage.get(\"login-return-state-params\"));" +
                    "\r\n                }, error => {\r\n                    $rootScope.$apply(() => {\r\n" +
                    "                        viewModel.errors = (error && error.message) ? error.mess" +
                    "age : error;\r\n                        if (viewModel.errors === \"No request state" +
                    " loaded\" && !oidcTokenManager.expired) {\r\n                            $state.go(" +
                    "localStorage.get(\"login-return-state\"), localStorage.get(\"login-return-state-par" +
                    "ams\"));\r\n                        }\r\n                    });\r\n                });" +
                    "\r\n            }]\r\n        };\r\n        controller = [\"$scope\", \"viewModel\", ($sco" +
                    "pe: ng.IScope, viewModel: IViewModel) => {\r\n            (<any>$scope).vm = viewM" +
                    "odel;\r\n        }];\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
