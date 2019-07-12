// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of an IoT hub.
    /// </summary>
    public partial class IotHubProperties
    {
        /// <summary>
        /// Initializes a new instance of the IotHubProperties class.
        /// </summary>
        public IotHubProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubProperties class.
        /// </summary>
        /// <param name="authorizationPolicies">The shared access policies you
        /// can use to secure a connection to the IoT hub.</param>
        /// <param name="ipFilterRules">The IP filter rules.</param>
        /// <param name="provisioningState">The provisioning state.</param>
        /// <param name="state">The hub state.</param>
        /// <param name="hostName">The name of the host.</param>
        /// <param name="eventHubEndpoints">The Event Hub-compatible endpoint
        /// properties. The only possible keys to this dictionary is events.
        /// This key has to be present in the dictionary while making create or
        /// update calls for the IoT hub.</param>
        /// <param name="storageEndpoints">The list of Azure Storage endpoints
        /// where you can upload files. Currently you can configure only one
        /// Azure Storage account and that MUST have its key as $default.
        /// Specifying more than one storage account causes an error to be
        /// thrown. Not specifying a value for this property when the
        /// enableFileUploadNotifications property is set to True, causes an
        /// error to be thrown.</param>
        /// <param name="messagingEndpoints">The messaging endpoint properties
        /// for the file upload notification queue.</param>
        /// <param name="enableFileUploadNotifications">If True, file upload
        /// notifications are enabled.</param>
        /// <param name="comments">IoT hub comments.</param>
        /// <param name="deviceStreams">The device streams properties of
        /// iothub.</param>
        /// <param name="features">The capabilities and features enabled for
        /// the IoT hub. Possible values include: 'None',
        /// 'DeviceManagement'</param>
        /// <param name="locations">Primary and secondary location for iot
        /// hub</param>
        public IotHubProperties(IList<SharedAccessSignatureAuthorizationRule> authorizationPolicies = default(IList<SharedAccessSignatureAuthorizationRule>), IList<IpFilterRule> ipFilterRules = default(IList<IpFilterRule>), string provisioningState = default(string), string state = default(string), string hostName = default(string), IDictionary<string, EventHubProperties> eventHubEndpoints = default(IDictionary<string, EventHubProperties>), RoutingProperties routing = default(RoutingProperties), IDictionary<string, StorageEndpointProperties> storageEndpoints = default(IDictionary<string, StorageEndpointProperties>), IDictionary<string, MessagingEndpointProperties> messagingEndpoints = default(IDictionary<string, MessagingEndpointProperties>), bool? enableFileUploadNotifications = default(bool?), CloudToDeviceProperties cloudToDevice = default(CloudToDeviceProperties), string comments = default(string), IotHubPropertiesDeviceStreams deviceStreams = default(IotHubPropertiesDeviceStreams), string features = default(string), IList<IotHubLocationDescription> locations = default(IList<IotHubLocationDescription>))
        {
            AuthorizationPolicies = authorizationPolicies;
            IpFilterRules = ipFilterRules;
            ProvisioningState = provisioningState;
            State = state;
            HostName = hostName;
            EventHubEndpoints = eventHubEndpoints;
            Routing = routing;
            StorageEndpoints = storageEndpoints;
            MessagingEndpoints = messagingEndpoints;
            EnableFileUploadNotifications = enableFileUploadNotifications;
            CloudToDevice = cloudToDevice;
            Comments = comments;
            DeviceStreams = deviceStreams;
            Features = features;
            Locations = locations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the shared access policies you can use to secure a
        /// connection to the IoT hub.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationPolicies")]
        public IList<SharedAccessSignatureAuthorizationRule> AuthorizationPolicies { get; set; }

        /// <summary>
        /// Gets or sets the IP filter rules.
        /// </summary>
        [JsonProperty(PropertyName = "ipFilterRules")]
        public IList<IpFilterRule> IpFilterRules { get; set; }

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the hub state.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the name of the host.
        /// </summary>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets or sets the Event Hub-compatible endpoint properties. The only
        /// possible keys to this dictionary is events. This key has to be
        /// present in the dictionary while making create or update calls for
        /// the IoT hub.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubEndpoints")]
        public IDictionary<string, EventHubProperties> EventHubEndpoints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "routing")]
        public RoutingProperties Routing { get; set; }

        /// <summary>
        /// Gets or sets the list of Azure Storage endpoints where you can
        /// upload files. Currently you can configure only one Azure Storage
        /// account and that MUST have its key as $default. Specifying more
        /// than one storage account causes an error to be thrown. Not
        /// specifying a value for this property when the
        /// enableFileUploadNotifications property is set to True, causes an
        /// error to be thrown.
        /// </summary>
        [JsonProperty(PropertyName = "storageEndpoints")]
        public IDictionary<string, StorageEndpointProperties> StorageEndpoints { get; set; }

        /// <summary>
        /// Gets or sets the messaging endpoint properties for the file upload
        /// notification queue.
        /// </summary>
        [JsonProperty(PropertyName = "messagingEndpoints")]
        public IDictionary<string, MessagingEndpointProperties> MessagingEndpoints { get; set; }

        /// <summary>
        /// Gets or sets if True, file upload notifications are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableFileUploadNotifications")]
        public bool? EnableFileUploadNotifications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cloudToDevice")]
        public CloudToDeviceProperties CloudToDevice { get; set; }

        /// <summary>
        /// Gets or sets ioT hub comments.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the device streams properties of iothub.
        /// </summary>
        [JsonProperty(PropertyName = "deviceStreams")]
        public IotHubPropertiesDeviceStreams DeviceStreams { get; set; }

        /// <summary>
        /// Gets or sets the capabilities and features enabled for the IoT hub.
        /// Possible values include: 'None', 'DeviceManagement'
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public string Features { get; set; }

        /// <summary>
        /// Gets primary and secondary location for iot hub
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<IotHubLocationDescription> Locations { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AuthorizationPolicies != null)
            {
                foreach (var element in AuthorizationPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (IpFilterRules != null)
            {
                foreach (var element1 in IpFilterRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Routing != null)
            {
                Routing.Validate();
            }
            if (StorageEndpoints != null)
            {
                foreach (var valueElement in StorageEndpoints.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (MessagingEndpoints != null)
            {
                foreach (var valueElement1 in MessagingEndpoints.Values)
                {
                    if (valueElement1 != null)
                    {
                        valueElement1.Validate();
                    }
                }
            }
            if (CloudToDevice != null)
            {
                CloudToDevice.Validate();
            }
        }
    }
}
