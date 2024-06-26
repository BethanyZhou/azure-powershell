// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Resync input.
    /// </summary>
    public partial class ResyncInput
    {
        /// <summary>
        /// Initializes a new instance of the ResyncInput class.
        /// </summary>
        public ResyncInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResyncInput class.
        /// </summary>

        /// <param name="properties">Resync input properties.
        /// </param>
        public ResyncInput(ResyncInputProperties properties)

        {
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resync input properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public ResyncInputProperties Properties {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Properties == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}