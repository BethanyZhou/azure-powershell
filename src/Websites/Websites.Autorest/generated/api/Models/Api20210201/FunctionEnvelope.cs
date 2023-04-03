// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>Function information.</summary>
    public partial class FunctionEnvelope :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelope,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource __proxyOnlyResource = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ProxyOnlyResource();

        /// <summary>Config information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.IAny Config { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).Config; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).Config = value ?? null /* model class */; }

        /// <summary>Config URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string ConfigHref { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).ConfigHref; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).ConfigHref = value ?? null; }

        /// <summary>File list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesFiles File { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).File; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).File = value ?? null /* model class */; }

        /// <summary>Function App ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string FunctionAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).FunctionAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).FunctionAppId = value ?? null; }

        /// <summary>Function URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string Href { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).Href; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).Href = value ?? null; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; }

        /// <summary>The invocation URL</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string InvokeUrlTemplate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).InvokeUrlTemplate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).InvokeUrlTemplate = value ?? null; }

        /// <summary>Gets or sets a value indicating whether the function is disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public bool? IsDisabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).IsDisabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).IsDisabled = value ?? default(bool); }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind = value ?? null; }

        /// <summary>The function language</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string Language { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).Language; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).Language = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopeProperties Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.FunctionEnvelopeProperties()); set { {_property = value;} } }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopeProperties _property;

        /// <summary>FunctionEnvelope resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.FunctionEnvelopeProperties()); set => this._property = value; }

        /// <summary>Script URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string ScriptHref { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).ScriptHref; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).ScriptHref = value ?? null; }

        /// <summary>Script root path URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string ScriptRootPathHref { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).ScriptRootPathHref; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).ScriptRootPathHref = value ?? null; }

        /// <summary>Secrets file URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string SecretsFileHref { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).SecretsFileHref; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).SecretsFileHref = value ?? null; }

        /// <summary>Test data used when testing via the Azure Portal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string TestData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).TestData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).TestData = value ?? null; }

        /// <summary>Test data URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string TestDataHref { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).TestDataHref; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesInternal)Property).TestDataHref = value ?? null; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; }

        /// <summary>Creates an new <see cref="FunctionEnvelope" /> instance.</summary>
        public FunctionEnvelope()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyOnlyResource), __proxyOnlyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyOnlyResource), __proxyOnlyResource);
        }
    }
    /// Function information.
    public partial interface IFunctionEnvelope :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource
    {
        /// <summary>Config information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Config information.",
        SerializedName = @"config",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.IAny Config { get; set; }
        /// <summary>Config URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Config URI.",
        SerializedName = @"config_href",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigHref { get; set; }
        /// <summary>File list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"File list.",
        SerializedName = @"files",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesFiles) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesFiles File { get; set; }
        /// <summary>Function App ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Function App ID.",
        SerializedName = @"function_app_id",
        PossibleTypes = new [] { typeof(string) })]
        string FunctionAppId { get; set; }
        /// <summary>Function URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Function URI.",
        SerializedName = @"href",
        PossibleTypes = new [] { typeof(string) })]
        string Href { get; set; }
        /// <summary>The invocation URL</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The invocation URL",
        SerializedName = @"invoke_url_template",
        PossibleTypes = new [] { typeof(string) })]
        string InvokeUrlTemplate { get; set; }
        /// <summary>Gets or sets a value indicating whether the function is disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets a value indicating whether the function is disabled",
        SerializedName = @"isDisabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDisabled { get; set; }
        /// <summary>The function language</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The function language",
        SerializedName = @"language",
        PossibleTypes = new [] { typeof(string) })]
        string Language { get; set; }
        /// <summary>Script URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Script URI.",
        SerializedName = @"script_href",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptHref { get; set; }
        /// <summary>Script root path URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Script root path URI.",
        SerializedName = @"script_root_path_href",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptRootPathHref { get; set; }
        /// <summary>Secrets file URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Secrets file URI.",
        SerializedName = @"secrets_file_href",
        PossibleTypes = new [] { typeof(string) })]
        string SecretsFileHref { get; set; }
        /// <summary>Test data used when testing via the Azure Portal.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Test data used when testing via the Azure Portal.",
        SerializedName = @"test_data",
        PossibleTypes = new [] { typeof(string) })]
        string TestData { get; set; }
        /// <summary>Test data URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Test data URI.",
        SerializedName = @"test_data_href",
        PossibleTypes = new [] { typeof(string) })]
        string TestDataHref { get; set; }

    }
    /// Function information.
    internal partial interface IFunctionEnvelopeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal
    {
        /// <summary>Config information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.IAny Config { get; set; }
        /// <summary>Config URI.</summary>
        string ConfigHref { get; set; }
        /// <summary>File list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopePropertiesFiles File { get; set; }
        /// <summary>Function App ID.</summary>
        string FunctionAppId { get; set; }
        /// <summary>Function URI.</summary>
        string Href { get; set; }
        /// <summary>The invocation URL</summary>
        string InvokeUrlTemplate { get; set; }
        /// <summary>Gets or sets a value indicating whether the function is disabled</summary>
        bool? IsDisabled { get; set; }
        /// <summary>The function language</summary>
        string Language { get; set; }
        /// <summary>FunctionEnvelope resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IFunctionEnvelopeProperties Property { get; set; }
        /// <summary>Script URI.</summary>
        string ScriptHref { get; set; }
        /// <summary>Script root path URI.</summary>
        string ScriptRootPathHref { get; set; }
        /// <summary>Secrets file URI.</summary>
        string SecretsFileHref { get; set; }
        /// <summary>Test data used when testing via the Azure Portal.</summary>
        string TestData { get; set; }
        /// <summary>Test data URI.</summary>
        string TestDataHref { get; set; }

    }
}