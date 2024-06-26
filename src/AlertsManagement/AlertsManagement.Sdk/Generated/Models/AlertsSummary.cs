// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Summary of alerts based on the input filters and &#39;groupby&#39; parameters.
    /// </summary>
    public partial class AlertsSummary : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AlertsSummary class.
        /// </summary>
        public AlertsSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertsSummary class.
        /// </summary>

        /// <param name="id">Azure resource Id
        /// </param>

        /// <param name="type">Azure resource type
        /// </param>

        /// <param name="name">Azure resource name
        /// </param>

        /// <param name="properties">Group the result set.
        /// </param>
        public AlertsSummary(string id = default(string), string type = default(string), string name = default(string), AlertsSummaryGroup properties = default(AlertsSummaryGroup))

        : base(id, type, name)
        {
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets group the result set.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public AlertsSummaryGroup Properties {get; set; }
    }
}