// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Model class for event details of a VMwareAzureV2 event.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageAzureV2")]
    public partial class InMageAzureV2EventDetails : EventProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageAzureV2EventDetails class.
        /// </summary>
        public InMageAzureV2EventDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageAzureV2EventDetails class.
        /// </summary>
        /// <param name="eventType">InMage Event type. Takes one of the values
        /// of {InMageDataContract.InMageMonitoringEventType}.</param>
        /// <param name="category">InMage Event Category.</param>
        /// <param name="component">InMage Event Component.</param>
        /// <param name="correctiveAction">Corrective Action string for the
        /// event.</param>
        /// <param name="details">InMage Event Details.</param>
        /// <param name="summary">InMage Event Summary.</param>
        /// <param name="siteName">VMware Site name.</param>
        public InMageAzureV2EventDetails(string eventType = default(string), string category = default(string), string component = default(string), string correctiveAction = default(string), string details = default(string), string summary = default(string), string siteName = default(string))
        {
            EventType = eventType;
            Category = category;
            Component = component;
            CorrectiveAction = correctiveAction;
            Details = details;
            Summary = summary;
            SiteName = siteName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets inMage Event type. Takes one of the values of
        /// {InMageDataContract.InMageMonitoringEventType}.
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets inMage Event Category.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets inMage Event Component.
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string Component { get; set; }

        /// <summary>
        /// Gets or sets corrective Action string for the event.
        /// </summary>
        [JsonProperty(PropertyName = "correctiveAction")]
        public string CorrectiveAction { get; set; }

        /// <summary>
        /// Gets or sets inMage Event Details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets inMage Event Summary.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets vMware Site name.
        /// </summary>
        [JsonProperty(PropertyName = "siteName")]
        public string SiteName { get; set; }

    }
}