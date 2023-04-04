// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The virtual network connection reset shared key.
    /// </summary>
    public partial class ConnectionResetSharedKey
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionResetSharedKey class.
        /// </summary>
        public ConnectionResetSharedKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionResetSharedKey class.
        /// </summary>
        /// <param name="keyLength">The virtual network connection reset shared
        /// key length, should between 1 and 128.</param>
        public ConnectionResetSharedKey(int keyLength)
        {
            KeyLength = keyLength;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual network connection reset shared key
        /// length, should between 1 and 128.
        /// </summary>
        [JsonProperty(PropertyName = "keyLength")]
        public int KeyLength { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyLength > 128)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "KeyLength", 128);
            }
            if (KeyLength < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "KeyLength", 1);
            }
        }
    }
}
