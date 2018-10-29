// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// REST API for Azure Logic Apps.
    /// </summary>
    public partial class LogicManagementClient : ServiceClient<LogicManagementClient>, ILogicManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription id.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The API version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IWorkflowsOperations.
        /// </summary>
        public virtual IWorkflowsOperations Workflows { get; private set; }

        /// <summary>
        /// Gets the IWorkflowVersionsOperations.
        /// </summary>
        public virtual IWorkflowVersionsOperations WorkflowVersions { get; private set; }

        /// <summary>
        /// Gets the IWorkflowTriggersOperations.
        /// </summary>
        public virtual IWorkflowTriggersOperations WorkflowTriggers { get; private set; }

        /// <summary>
        /// Gets the IWorkflowVersionTriggersOperations.
        /// </summary>
        public virtual IWorkflowVersionTriggersOperations WorkflowVersionTriggers { get; private set; }

        /// <summary>
        /// Gets the IWorkflowTriggerHistoriesOperations.
        /// </summary>
        public virtual IWorkflowTriggerHistoriesOperations WorkflowTriggerHistories { get; private set; }

        /// <summary>
        /// Gets the IWorkflowRunsOperations.
        /// </summary>
        public virtual IWorkflowRunsOperations WorkflowRuns { get; private set; }

        /// <summary>
        /// Gets the IWorkflowRunActionsOperations.
        /// </summary>
        public virtual IWorkflowRunActionsOperations WorkflowRunActions { get; private set; }

        /// <summary>
        /// Gets the IWorkflowRunActionRepetitionsOperations.
        /// </summary>
        public virtual IWorkflowRunActionRepetitionsOperations WorkflowRunActionRepetitions { get; private set; }

        /// <summary>
        /// Gets the IWorkflowRunActionScopeRepetitionsOperations.
        /// </summary>
        public virtual IWorkflowRunActionScopeRepetitionsOperations WorkflowRunActionScopeRepetitions { get; private set; }

        /// <summary>
        /// Gets the IWorkflowRunOperations.
        /// </summary>
        public virtual IWorkflowRunOperations WorkflowRunOperations { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountsOperations.
        /// </summary>
        public virtual IIntegrationAccountsOperations IntegrationAccounts { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountAssembliesOperations.
        /// </summary>
        public virtual IIntegrationAccountAssembliesOperations IntegrationAccountAssemblies { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountBatchConfigurationsOperations.
        /// </summary>
        public virtual IIntegrationAccountBatchConfigurationsOperations IntegrationAccountBatchConfigurations { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountSchemasOperations.
        /// </summary>
        public virtual IIntegrationAccountSchemasOperations IntegrationAccountSchemas { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountMapsOperations.
        /// </summary>
        public virtual IIntegrationAccountMapsOperations IntegrationAccountMaps { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountPartnersOperations.
        /// </summary>
        public virtual IIntegrationAccountPartnersOperations IntegrationAccountPartners { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountAgreementsOperations.
        /// </summary>
        public virtual IIntegrationAccountAgreementsOperations IntegrationAccountAgreements { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountCertificatesOperations.
        /// </summary>
        public virtual IIntegrationAccountCertificatesOperations IntegrationAccountCertificates { get; private set; }

        /// <summary>
        /// Gets the IIntegrationAccountSessionsOperations.
        /// </summary>
        public virtual IIntegrationAccountSessionsOperations IntegrationAccountSessions { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling LogicManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        protected LogicManagementClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected LogicManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected LogicManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected LogicManagementClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected LogicManagementClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public LogicManagementClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling LogicManagementClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public LogicManagementClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public LogicManagementClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public LogicManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the LogicManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public LogicManagementClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Workflows = new WorkflowsOperations(this);
            WorkflowVersions = new WorkflowVersionsOperations(this);
            WorkflowTriggers = new WorkflowTriggersOperations(this);
            WorkflowVersionTriggers = new WorkflowVersionTriggersOperations(this);
            WorkflowTriggerHistories = new WorkflowTriggerHistoriesOperations(this);
            WorkflowRuns = new WorkflowRunsOperations(this);
            WorkflowRunActions = new WorkflowRunActionsOperations(this);
            WorkflowRunActionRepetitions = new WorkflowRunActionRepetitionsOperations(this);
            WorkflowRunActionScopeRepetitions = new WorkflowRunActionScopeRepetitionsOperations(this);
            WorkflowRunOperations = new WorkflowRunOperations(this);
            IntegrationAccounts = new IntegrationAccountsOperations(this);
            IntegrationAccountAssemblies = new IntegrationAccountAssembliesOperations(this);
            IntegrationAccountBatchConfigurations = new IntegrationAccountBatchConfigurationsOperations(this);
            IntegrationAccountSchemas = new IntegrationAccountSchemasOperations(this);
            IntegrationAccountMaps = new IntegrationAccountMapsOperations(this);
            IntegrationAccountPartners = new IntegrationAccountPartnersOperations(this);
            IntegrationAccountAgreements = new IntegrationAccountAgreementsOperations(this);
            IntegrationAccountCertificates = new IntegrationAccountCertificatesOperations(this);
            IntegrationAccountSessions = new IntegrationAccountSessionsOperations(this);
            Operations = new Operations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2018-07-01-preview";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}