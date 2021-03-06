// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IP firewall rule properties
    /// </summary>
    public partial class IpFirewallRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the IpFirewallRuleProperties class.
        /// </summary>
        public IpFirewallRuleProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpFirewallRuleProperties class.
        /// </summary>
        /// <param name="endIpAddress">The end IP address of the firewall rule.
        /// Must be IPv4 format. Must be greater than or equal to
        /// startIpAddress</param>
        /// <param name="provisioningState">Resource provisioning state.
        /// Possible values include: 'Provisioning', 'Succeeded', 'Deleting',
        /// 'Failed', 'DeleteError'</param>
        /// <param name="startIpAddress">The start IP address of the firewall
        /// rule. Must be IPv4 format</param>
        public IpFirewallRuleProperties(string endIpAddress = default(string), string provisioningState = default(string), string startIpAddress = default(string))
        {
            EndIpAddress = endIpAddress;
            ProvisioningState = provisioningState;
            StartIpAddress = startIpAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the end IP address of the firewall rule. Must be IPv4
        /// format. Must be greater than or equal to startIpAddress
        /// </summary>
        [JsonProperty(PropertyName = "endIpAddress")]
        public string EndIpAddress { get; set; }

        /// <summary>
        /// Gets resource provisioning state. Possible values include:
        /// 'Provisioning', 'Succeeded', 'Deleting', 'Failed', 'DeleteError'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the start IP address of the firewall rule. Must be
        /// IPv4 format
        /// </summary>
        [JsonProperty(PropertyName = "startIpAddress")]
        public string StartIpAddress { get; set; }

    }
}
