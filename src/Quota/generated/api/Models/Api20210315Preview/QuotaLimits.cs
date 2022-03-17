// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Extensions;

    /// <summary>Quota limits.</summary>
    public partial class QuotaLimits :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaLimits,
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaLimitsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; set => this._eTag = value; }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The URI used to fetch the next page of quota limits. When there are no more pages, this string is null.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase[] _value;

        /// <summary>List of quota limits.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quota.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase[] Value { get => this._value; set => this._value = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("ETag", out var __eTagHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.IQuotaLimitsInternal)this).ETag = System.Linq.Enumerable.FirstOrDefault(__eTagHeader0) is string __headerETagHeader0 ? __headerETagHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="QuotaLimits" /> instance.</summary>
        public QuotaLimits()
        {

        }
    }
    /// Quota limits.
    public partial interface IQuotaLimits :
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ETag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get; set; }
        /// <summary>
        /// The URI used to fetch the next page of quota limits. When there are no more pages, this string is null.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI used to fetch the next page of quota limits. When there are no more pages, this string is null.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of quota limits.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quota.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of quota limits.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase) })]
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase[] Value { get; set; }

    }
    /// Quota limits.
    internal partial interface IQuotaLimitsInternal

    {
        string ETag { get; set; }
        /// <summary>
        /// The URI used to fetch the next page of quota limits. When there are no more pages, this string is null.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>List of quota limits.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Quota.Models.Api20210315Preview.ICurrentQuotaLimitBase[] Value { get; set; }

    }
}