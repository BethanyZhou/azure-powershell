// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.PowerShell;

    /// <summary>MSDeploy ARM PUT core information</summary>
    [System.ComponentModel.TypeConverter(typeof(MSDeployCoreTypeConverter))]
    public partial class MSDeployCore
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MSDeployCore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCore" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCore DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MSDeployCore(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MSDeployCore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCore" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCore DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MSDeployCore(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MSDeployCore" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MSDeployCore" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCore FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MSDeployCore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MSDeployCore(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PackageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).PackageUri = (string) content.GetValueForProperty("PackageUri",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).PackageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).ConnectionString = (string) content.GetValueForProperty("ConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).ConnectionString, global::System.Convert.ToString);
            }
            if (content.Contains("DbType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).DbType = (string) content.GetValueForProperty("DbType",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).DbType, global::System.Convert.ToString);
            }
            if (content.Contains("SetParametersXmlFileUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParametersXmlFileUri = (string) content.GetValueForProperty("SetParametersXmlFileUri",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParametersXmlFileUri, global::System.Convert.ToString);
            }
            if (content.Contains("SetParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParameter = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreSetParameters) content.GetValueForProperty("SetParameter",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParameter, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MSDeployCoreSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkipAppData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SkipAppData = (bool?) content.GetValueForProperty("SkipAppData",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SkipAppData, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AppOffline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).AppOffline = (bool?) content.GetValueForProperty("AppOffline",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).AppOffline, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MSDeployCore"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MSDeployCore(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PackageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).PackageUri = (string) content.GetValueForProperty("PackageUri",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).PackageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).ConnectionString = (string) content.GetValueForProperty("ConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).ConnectionString, global::System.Convert.ToString);
            }
            if (content.Contains("DbType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).DbType = (string) content.GetValueForProperty("DbType",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).DbType, global::System.Convert.ToString);
            }
            if (content.Contains("SetParametersXmlFileUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParametersXmlFileUri = (string) content.GetValueForProperty("SetParametersXmlFileUri",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParametersXmlFileUri, global::System.Convert.ToString);
            }
            if (content.Contains("SetParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParameter = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreSetParameters) content.GetValueForProperty("SetParameter",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SetParameter, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.MSDeployCoreSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkipAppData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SkipAppData = (bool?) content.GetValueForProperty("SkipAppData",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).SkipAppData, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AppOffline"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).AppOffline = (bool?) content.GetValueForProperty("AppOffline",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IMSDeployCoreInternal)this).AppOffline, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// MSDeploy ARM PUT core information
    [System.ComponentModel.TypeConverter(typeof(MSDeployCoreTypeConverter))]
    public partial interface IMSDeployCore

    {

    }
}