// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.PowerShell;

    /// <summary>Description of a restore request.</summary>
    [System.ComponentModel.TypeConverter(typeof(RestoreRequestTypeConverter))]
    public partial class RestoreRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RestoreRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequest" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RestoreRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RestoreRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RestoreRequest" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RestoreRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RestoreRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).StorageAccountUrl = (string) content.GetValueForProperty("StorageAccountUrl",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).StorageAccountUrl, global::System.Convert.ToString);
            }
            if (content.Contains("BlobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).BlobName = (string) content.GetValueForProperty("BlobName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).BlobName, global::System.Convert.ToString);
            }
            if (content.Contains("Overwrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Overwrite = (bool) content.GetValueForProperty("Overwrite",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Overwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SiteName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).SiteName = (string) content.GetValueForProperty("SiteName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).SiteName, global::System.Convert.ToString);
            }
            if (content.Contains("Database"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Database = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDatabaseBackupSetting[]) content.GetValueForProperty("Database",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Database, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDatabaseBackupSetting>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.DatabaseBackupSettingTypeConverter.ConvertFrom));
            }
            if (content.Contains("IgnoreConflictingHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreConflictingHostName = (bool?) content.GetValueForProperty("IgnoreConflictingHostName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreConflictingHostName, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IgnoreDatabase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreDatabase = (bool?) content.GetValueForProperty("IgnoreDatabase",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreDatabase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AppServicePlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AppServicePlan = (string) content.GetValueForProperty("AppServicePlan",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AppServicePlan, global::System.Convert.ToString);
            }
            if (content.Contains("OperationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).OperationType = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType?) content.GetValueForProperty("OperationType",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).OperationType, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType.CreateFrom);
            }
            if (content.Contains("AdjustConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AdjustConnectionString = (bool?) content.GetValueForProperty("AdjustConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AdjustConnectionString, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HostingEnvironment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).HostingEnvironment = (string) content.GetValueForProperty("HostingEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).HostingEnvironment, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RestoreRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.RestoreRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).StorageAccountUrl = (string) content.GetValueForProperty("StorageAccountUrl",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).StorageAccountUrl, global::System.Convert.ToString);
            }
            if (content.Contains("BlobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).BlobName = (string) content.GetValueForProperty("BlobName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).BlobName, global::System.Convert.ToString);
            }
            if (content.Contains("Overwrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Overwrite = (bool) content.GetValueForProperty("Overwrite",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Overwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SiteName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).SiteName = (string) content.GetValueForProperty("SiteName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).SiteName, global::System.Convert.ToString);
            }
            if (content.Contains("Database"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Database = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDatabaseBackupSetting[]) content.GetValueForProperty("Database",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).Database, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDatabaseBackupSetting>(__y, Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.DatabaseBackupSettingTypeConverter.ConvertFrom));
            }
            if (content.Contains("IgnoreConflictingHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreConflictingHostName = (bool?) content.GetValueForProperty("IgnoreConflictingHostName",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreConflictingHostName, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IgnoreDatabase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreDatabase = (bool?) content.GetValueForProperty("IgnoreDatabase",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).IgnoreDatabase, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AppServicePlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AppServicePlan = (string) content.GetValueForProperty("AppServicePlan",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AppServicePlan, global::System.Convert.ToString);
            }
            if (content.Contains("OperationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).OperationType = (Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType?) content.GetValueForProperty("OperationType",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).OperationType, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType.CreateFrom);
            }
            if (content.Contains("AdjustConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AdjustConnectionString = (bool?) content.GetValueForProperty("AdjustConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).AdjustConnectionString, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HostingEnvironment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).HostingEnvironment = (string) content.GetValueForProperty("HostingEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IRestoreRequestInternal)this).HostingEnvironment, global::System.Convert.ToString);
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
    /// Description of a restore request.
    [System.ComponentModel.TypeConverter(typeof(RestoreRequestTypeConverter))]
    public partial interface IRestoreRequest

    {

    }
}