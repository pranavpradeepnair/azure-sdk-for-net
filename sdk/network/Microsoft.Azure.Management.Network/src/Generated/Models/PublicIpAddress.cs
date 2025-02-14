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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Public IP address resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PublicIPAddress : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddress class.
        /// </summary>
        public PublicIPAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddress class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The public IP address SKU.</param>
        /// <param name="publicIPAllocationMethod">The public IP address
        /// allocation method. Possible values include: 'Static',
        /// 'Dynamic'</param>
        /// <param name="publicIPAddressVersion">The public IP address version.
        /// Possible values include: 'IPv4', 'IPv6'</param>
        /// <param name="ipConfiguration">The IP configuration associated with
        /// the public IP address.</param>
        /// <param name="dnsSettings">The FQDN of the DNS record associated
        /// with the public IP address.</param>
        /// <param name="ddosSettings">The DDoS protection custom policy
        /// associated with the public IP address.</param>
        /// <param name="ipTags">The list of tags associated with the public IP
        /// address.</param>
        /// <param name="ipAddress">The IP address associated with the public
        /// IP address resource.</param>
        /// <param name="publicIPPrefix">The Public IP Prefix this Public IP
        /// Address should be allocated from.</param>
        /// <param name="idleTimeoutInMinutes">The idle timeout of the public
        /// IP address.</param>
        /// <param name="resourceGuid">The resource GUID property of the public
        /// IP address resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// public IP address resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="zones">A list of availability zones denoting the IP
        /// allocated for the resource needs to come from.</param>
        public PublicIPAddress(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), PublicIPAddressSku sku = default(PublicIPAddressSku), string publicIPAllocationMethod = default(string), string publicIPAddressVersion = default(string), IPConfiguration ipConfiguration = default(IPConfiguration), PublicIPAddressDnsSettings dnsSettings = default(PublicIPAddressDnsSettings), DdosSettings ddosSettings = default(DdosSettings), IList<IpTag> ipTags = default(IList<IpTag>), string ipAddress = default(string), SubResource publicIPPrefix = default(SubResource), int? idleTimeoutInMinutes = default(int?), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string), IList<string> zones = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            PublicIPAllocationMethod = publicIPAllocationMethod;
            PublicIPAddressVersion = publicIPAddressVersion;
            IpConfiguration = ipConfiguration;
            DnsSettings = dnsSettings;
            DdosSettings = ddosSettings;
            IpTags = ipTags;
            IpAddress = ipAddress;
            PublicIPPrefix = publicIPPrefix;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the public IP address SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public PublicIPAddressSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the public IP address allocation method. Possible
        /// values include: 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAllocationMethod")]
        public string PublicIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the public IP address version. Possible values
        /// include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddressVersion")]
        public string PublicIPAddressVersion { get; set; }

        /// <summary>
        /// Gets the IP configuration associated with the public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfiguration")]
        public IPConfiguration IpConfiguration { get; private set; }

        /// <summary>
        /// Gets or sets the FQDN of the DNS record associated with the public
        /// IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public PublicIPAddressDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets the DDoS protection custom policy associated with the
        /// public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ddosSettings")]
        public DdosSettings DdosSettings { get; set; }

        /// <summary>
        /// Gets or sets the list of tags associated with the public IP
        /// address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipTags")]
        public IList<IpTag> IpTags { get; set; }

        /// <summary>
        /// Gets or sets the IP address associated with the public IP address
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the Public IP Prefix this Public IP Address should be
        /// allocated from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPPrefix")]
        public SubResource PublicIPPrefix { get; set; }

        /// <summary>
        /// Gets or sets the idle timeout of the public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the public IP address
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the public IP address
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting the IP allocated
        /// for the resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

    }
}
