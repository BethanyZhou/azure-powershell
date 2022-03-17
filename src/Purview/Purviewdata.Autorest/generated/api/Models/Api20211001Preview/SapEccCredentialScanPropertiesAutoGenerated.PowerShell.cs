// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(SapEccCredentialScanPropertiesAutoGeneratedTypeConverter))]
    public partial class SapEccCredentialScanPropertiesAutoGenerated
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.SapEccCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SapEccCredentialScanPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.SapEccCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SapEccCredentialScanPropertiesAutoGenerated(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SapEccCredentialScanPropertiesAutoGenerated" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.SapEccCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SapEccCredentialScanPropertiesAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CollectionReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionReferenceName = (string) content.GetValueForProperty("CollectionReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectedViaReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedViaReferenceName = (string) content.GetValueForProperty("ConnectedViaReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedViaReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CollectionLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("CollectionLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CollectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionType = (string) content.GetValueForProperty("CollectionType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionType, global::System.Convert.ToString);
            }
            if (content.Contains("Collection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Collection = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference) content.GetValueForProperty("Collection",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Collection, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CollectionReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConnectedVia"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedVia = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IConnectedVia) content.GetValueForProperty("ConnectedVia",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedVia, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ConnectedViaTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScanRulesetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetName = (string) content.GetValueForProperty("ScanRulesetName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetName, global::System.Convert.ToString);
            }
            if (content.Contains("ScanRulesetType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetType = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType?) content.GetValueForProperty("ScanRulesetType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetType, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType.CreateFrom);
            }
            if (content.Contains("Worker"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Worker = (int?) content.GetValueForProperty("Worker",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Worker, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MaximumMemoryAllowedInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MaximumMemoryAllowedInGb = (string) content.GetValueForProperty("MaximumMemoryAllowedInGb",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MaximumMemoryAllowedInGb, global::System.Convert.ToString);
            }
            if (content.Contains("MitiCache"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MitiCache = (string) content.GetValueForProperty("MitiCache",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MitiCache, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialReferenceName = (string) content.GetValueForProperty("CredentialReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialType = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType?) content.GetValueForProperty("CredentialType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialType, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType.CreateFrom);
            }
            if (content.Contains("Credential"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).Credential = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference) content.GetValueForProperty("Credential",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).Credential, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CredentialReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("JCoLibraryPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).JCoLibraryPath = (string) content.GetValueForProperty("JCoLibraryPath",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).JCoLibraryPath, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.SapEccCredentialScanPropertiesAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SapEccCredentialScanPropertiesAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CollectionReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionReferenceName = (string) content.GetValueForProperty("CollectionReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectedViaReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedViaReferenceName = (string) content.GetValueForProperty("ConnectedViaReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedViaReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CollectionLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("CollectionLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CollectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionType = (string) content.GetValueForProperty("CollectionType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CollectionType, global::System.Convert.ToString);
            }
            if (content.Contains("Collection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Collection = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference) content.GetValueForProperty("Collection",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Collection, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CollectionReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConnectedVia"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedVia = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IConnectedVia) content.GetValueForProperty("ConnectedVia",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ConnectedVia, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ConnectedViaTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScanRulesetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetName = (string) content.GetValueForProperty("ScanRulesetName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetName, global::System.Convert.ToString);
            }
            if (content.Contains("ScanRulesetType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetType = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType?) content.GetValueForProperty("ScanRulesetType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).ScanRulesetType, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType.CreateFrom);
            }
            if (content.Contains("Worker"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Worker = (int?) content.GetValueForProperty("Worker",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).Worker, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScanPropertiesInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MaximumMemoryAllowedInGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MaximumMemoryAllowedInGb = (string) content.GetValueForProperty("MaximumMemoryAllowedInGb",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MaximumMemoryAllowedInGb, global::System.Convert.ToString);
            }
            if (content.Contains("MitiCache"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MitiCache = (string) content.GetValueForProperty("MitiCache",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IMitiScanPropertiesInternal)this).MitiCache, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialReferenceName = (string) content.GetValueForProperty("CredentialReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialType = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType?) content.GetValueForProperty("CredentialType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).CredentialType, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType.CreateFrom);
            }
            if (content.Contains("Credential"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).Credential = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICredentialReference) content.GetValueForProperty("Credential",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).Credential, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CredentialReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("JCoLibraryPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).JCoLibraryPath = (string) content.GetValueForProperty("JCoLibraryPath",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ISapEccCredentialScanPropertiesInternal)this).JCoLibraryPath, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(SapEccCredentialScanPropertiesAutoGeneratedTypeConverter))]
    public partial interface ISapEccCredentialScanPropertiesAutoGenerated

    {

    }
}