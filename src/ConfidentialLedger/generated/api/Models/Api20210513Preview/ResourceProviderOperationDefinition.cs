// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Extensions;

    /// <summary>Describes the Resource Provider Operation.</summary>
    public partial class ResourceProviderOperationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplay _display;

        /// <summary>Details about the operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.ResourceProviderOperationDisplay()); set => this._display = value; }

        /// <summary>Description of the resource provider operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Description = value ?? null; }

        /// <summary>Name of the resource provider operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>Name of the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>Name of the resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Backing field for <see cref="IsDataAction" /> property.</summary>
        private bool? _isDataAction;

        /// <summary>Indicates whether the operation is data action or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Owned)]
        public bool? IsDataAction { get => this._isDataAction; set => this._isDataAction = value; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplay Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDefinitionInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.ResourceProviderOperationDisplay()); set { {_display = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Resource provider operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ResourceProviderOperationDefinition" /> instance.</summary>
        public ResourceProviderOperationDefinition()
        {

        }
    }
    /// Describes the Resource Provider Operation.
    public partial interface IResourceProviderOperationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.IJsonSerializable
    {
        /// <summary>Description of the resource provider operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the resource provider operation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Name of the resource provider operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource provider operation.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Name of the resource provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource provider.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>Name of the resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource type.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Indicates whether the operation is data action or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the operation is data action or not.",
        SerializedName = @"isDataAction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDataAction { get; set; }
        /// <summary>Resource provider operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource provider operation name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Describes the Resource Provider Operation.
    internal partial interface IResourceProviderOperationDefinitionInternal

    {
        /// <summary>Details about the operations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20210513Preview.IResourceProviderOperationDisplay Display { get; set; }
        /// <summary>Description of the resource provider operation.</summary>
        string DisplayDescription { get; set; }
        /// <summary>Name of the resource provider operation.</summary>
        string DisplayOperation { get; set; }
        /// <summary>Name of the resource provider.</summary>
        string DisplayProvider { get; set; }
        /// <summary>Name of the resource type.</summary>
        string DisplayResource { get; set; }
        /// <summary>Indicates whether the operation is data action or not.</summary>
        bool? IsDataAction { get; set; }
        /// <summary>Resource provider operation name.</summary>
        string Name { get; set; }

    }
}