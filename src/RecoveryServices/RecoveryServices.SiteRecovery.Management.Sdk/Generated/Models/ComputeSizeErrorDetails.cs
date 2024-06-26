// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Represents the error used to indicate why the target compute size is not
    /// applicable.
    /// </summary>
    public partial class ComputeSizeErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the ComputeSizeErrorDetails class.
        /// </summary>
        public ComputeSizeErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeSizeErrorDetails class.
        /// </summary>

        /// <param name="message">The error message.
        /// </param>

        /// <param name="severity">The severity of the error.
        /// </param>
        public ComputeSizeErrorDetails(string message = default(string), string severity = default(string))

        {
            this.Message = message;
            this.Severity = severity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get; set; }

        /// <summary>
        /// Gets or sets the severity of the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "severity")]
        public string Severity {get; set; }
    }
}