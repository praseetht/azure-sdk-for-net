// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a server to be created.
    /// </summary>
    public partial class ServerForCreate
    {
        /// <summary>
        /// Initializes a new instance of the ServerForCreate class.
        /// </summary>
        public ServerForCreate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerForCreate class.
        /// </summary>
        /// <param name="properties">Properties of the server.</param>
        /// <param name="location">The location the resource resides
        /// in.</param>
        /// <param name="identity">The Azure Active Directory identity of the
        /// server.</param>
        /// <param name="sku">The SKU (pricing tier) of the server.</param>
        /// <param name="tags">Application-specific metadata in the form of
        /// key-value pairs.</param>
        public ServerForCreate(ServerPropertiesForCreate properties, string location, ResourceIdentity identity = default(ResourceIdentity), Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Identity = identity;
            Sku = sku;
            Properties = properties;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory identity of the server.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the SKU (pricing tier) of the server.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets properties of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ServerPropertiesForCreate Properties { get; set; }

        /// <summary>
        /// Gets or sets the location the resource resides in.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
