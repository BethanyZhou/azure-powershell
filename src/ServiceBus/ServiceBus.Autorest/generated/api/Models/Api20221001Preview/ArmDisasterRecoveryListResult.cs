// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>The result of the List Alias(Disaster Recovery configuration) operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class ArmDisasterRecoveryListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecoveryListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecoveryListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecoveryListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Alias(Disaster Recovery configuration)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecovery[] _value;

        /// <summary>List of Alias(Disaster Recovery configurations)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecovery[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ArmDisasterRecoveryListResult" /> instance.</summary>
        public ArmDisasterRecoveryListResult()
        {

        }
    }
    /// The result of the List Alias(Disaster Recovery configuration) operation.
    public partial interface IArmDisasterRecoveryListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Alias(Disaster Recovery configuration)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to the next set of results. Not empty if Value contains incomplete list of Alias(Disaster Recovery configuration)",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of Alias(Disaster Recovery configurations)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Alias(Disaster Recovery configurations)",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecovery) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecovery[] Value { get; set; }

    }
    /// The result of the List Alias(Disaster Recovery configuration) operation.
    internal partial interface IArmDisasterRecoveryListResultInternal

    {
        /// <summary>
        /// Link to the next set of results. Not empty if Value contains incomplete list of Alias(Disaster Recovery configuration)
        /// </summary>
        string NextLink { get; set; }
        /// <summary>List of Alias(Disaster Recovery configurations)</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.Api20221001Preview.IArmDisasterRecovery[] Value { get; set; }

    }
}