// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>
    /// The configuration settings that determines the validation flow of users using App Service Authentication/Authorization.
    /// </summary>
    public partial class GlobalValidation :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IGlobalValidation,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IGlobalValidationInternal
    {

        /// <summary>Backing field for <see cref="ExcludedPath" /> property.</summary>
        private string[] _excludedPath;

        /// <summary>
        /// The paths for which unauthenticated flow would not be redirected to the login page.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string[] ExcludedPath { get => this._excludedPath; set => this._excludedPath = value; }

        /// <summary>Backing field for <see cref="RedirectToProvider" /> property.</summary>
        private string _redirectToProvider;

        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string RedirectToProvider { get => this._redirectToProvider; set => this._redirectToProvider = value; }

        /// <summary>Backing field for <see cref="RequireAuthentication" /> property.</summary>
        private bool? _requireAuthentication;

        /// <summary>
        /// <code>true</code> if the authentication flow is required any request is made; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public bool? RequireAuthentication { get => this._requireAuthentication; set => this._requireAuthentication = value; }

        /// <summary>Backing field for <see cref="UnauthenticatedClientAction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2? _unauthenticatedClientAction;

        /// <summary>The action to take when an unauthenticated client attempts to access the app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2? UnauthenticatedClientAction { get => this._unauthenticatedClientAction; set => this._unauthenticatedClientAction = value; }

        /// <summary>Creates an new <see cref="GlobalValidation" /> instance.</summary>
        public GlobalValidation()
        {

        }
    }
    /// The configuration settings that determines the validation flow of users using App Service Authentication/Authorization.
    public partial interface IGlobalValidation :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The paths for which unauthenticated flow would not be redirected to the login page.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The paths for which unauthenticated flow would not be redirected to the login page.",
        SerializedName = @"excludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] ExcludedPath { get; set; }
        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default authentication provider to use when multiple providers are configured.
        This setting is only needed if multiple providers are configured and the unauthenticated client
        action is set to ""RedirectToLoginPage"".",
        SerializedName = @"redirectToProvider",
        PossibleTypes = new [] { typeof(string) })]
        string RedirectToProvider { get; set; }
        /// <summary>
        /// <code>true</code> if the authentication flow is required any request is made; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"<code>true</code> if the authentication flow is required any request is made; otherwise, <code>false</code>.",
        SerializedName = @"requireAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RequireAuthentication { get; set; }
        /// <summary>The action to take when an unauthenticated client attempts to access the app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The action to take when an unauthenticated client attempts to access the app.",
        SerializedName = @"unauthenticatedClientAction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2? UnauthenticatedClientAction { get; set; }

    }
    /// The configuration settings that determines the validation flow of users using App Service Authentication/Authorization.
    internal partial interface IGlobalValidationInternal

    {
        /// <summary>
        /// The paths for which unauthenticated flow would not be redirected to the login page.
        /// </summary>
        string[] ExcludedPath { get; set; }
        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        /// This setting is only needed if multiple providers are configured and the unauthenticated client
        /// action is set to "RedirectToLoginPage".
        /// </summary>
        string RedirectToProvider { get; set; }
        /// <summary>
        /// <code>true</code> if the authentication flow is required any request is made; otherwise, <code>false</code>.
        /// </summary>
        bool? RequireAuthentication { get; set; }
        /// <summary>The action to take when an unauthenticated client attempts to access the app.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2? UnauthenticatedClientAction { get; set; }

    }
}