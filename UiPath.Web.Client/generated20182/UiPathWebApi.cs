// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    public partial class UiPathWebApi : ServiceClient<UiPathWebApi>, IUiPathWebApi
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
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets the IAccount.
        /// </summary>
        public virtual IAccount Account { get; private set; }

        /// <summary>
        /// Gets the ILogs.
        /// </summary>
        public virtual ILogs Logs { get; private set; }

        /// <summary>
        /// Gets the IRobotsService.
        /// </summary>
        public virtual IRobotsService RobotsService { get; private set; }

        /// <summary>
        /// Gets the IStats.
        /// </summary>
        public virtual IStats Stats { get; private set; }

        /// <summary>
        /// Gets the IStatus.
        /// </summary>
        public virtual IStatus Status { get; private set; }

        /// <summary>
        /// Gets the ITranslations.
        /// </summary>
        public virtual ITranslations Translations { get; private set; }

        /// <summary>
        /// Gets the IAlerts.
        /// </summary>
        public virtual IAlerts Alerts { get; private set; }

        /// <summary>
        /// Gets the IAssets.
        /// </summary>
        public virtual IAssets Assets { get; private set; }

        /// <summary>
        /// Gets the IAuditLogs.
        /// </summary>
        public virtual IAuditLogs AuditLogs { get; private set; }

        /// <summary>
        /// Gets the IEnvironments.
        /// </summary>
        public virtual IEnvironments Environments { get; private set; }

        /// <summary>
        /// Gets the IJobs.
        /// </summary>
        public virtual IJobs Jobs { get; private set; }

        /// <summary>
        /// Gets the ILicensesNamedUser.
        /// </summary>
        public virtual ILicensesNamedUser LicensesNamedUser { get; private set; }

        /// <summary>
        /// Gets the ILicensesRuntime.
        /// </summary>
        public virtual ILicensesRuntime LicensesRuntime { get; private set; }

        /// <summary>
        /// Gets the IMachines.
        /// </summary>
        public virtual IMachines Machines { get; private set; }

        /// <summary>
        /// Gets the IOrganizationUnits.
        /// </summary>
        public virtual IOrganizationUnits OrganizationUnits { get; private set; }

        /// <summary>
        /// Gets the IPermissions.
        /// </summary>
        public virtual IPermissions Permissions { get; private set; }

        /// <summary>
        /// Gets the IProcesses.
        /// </summary>
        public virtual IProcesses Processes { get; private set; }

        /// <summary>
        /// Gets the IProcessSchedules.
        /// </summary>
        public virtual IProcessSchedules ProcessSchedules { get; private set; }

        /// <summary>
        /// Gets the IQueueDefinitions.
        /// </summary>
        public virtual IQueueDefinitions QueueDefinitions { get; private set; }

        /// <summary>
        /// Gets the IQueueItemComments.
        /// </summary>
        public virtual IQueueItemComments QueueItemComments { get; private set; }

        /// <summary>
        /// Gets the IQueueItemEvents.
        /// </summary>
        public virtual IQueueItemEvents QueueItemEvents { get; private set; }

        /// <summary>
        /// Gets the IQueueItems.
        /// </summary>
        public virtual IQueueItems QueueItems { get; private set; }

        /// <summary>
        /// Gets the IQueueProcessingRecords.
        /// </summary>
        public virtual IQueueProcessingRecords QueueProcessingRecords { get; private set; }

        /// <summary>
        /// Gets the IQueues.
        /// </summary>
        public virtual IQueues Queues { get; private set; }

        /// <summary>
        /// Gets the IReleases.
        /// </summary>
        public virtual IReleases Releases { get; private set; }

        /// <summary>
        /// Gets the IRobotLogs.
        /// </summary>
        public virtual IRobotLogs RobotLogs { get; private set; }

        /// <summary>
        /// Gets the IRobots.
        /// </summary>
        public virtual IRobots Robots { get; private set; }

        /// <summary>
        /// Gets the IRoles.
        /// </summary>
        public virtual IRoles Roles { get; private set; }

        /// <summary>
        /// Gets the ISessions.
        /// </summary>
        public virtual ISessions Sessions { get; private set; }

        /// <summary>
        /// Gets the ISettings.
        /// </summary>
        public virtual ISettings Settings { get; private set; }

        /// <summary>
        /// Gets the ITenants.
        /// </summary>
        public virtual ITenants Tenants { get; private set; }

        /// <summary>
        /// Gets the IUserLoginAttempts.
        /// </summary>
        public virtual IUserLoginAttempts UserLoginAttempts { get; private set; }

        /// <summary>
        /// Gets the IUsers.
        /// </summary>
        public virtual IUsers Users { get; private set; }

        /// <summary>
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling UiPathWebApi.Dispose(). False: will not dispose provided httpClient</param>
        protected UiPathWebApi(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected UiPathWebApi(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected UiPathWebApi(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the UiPathWebApi class.
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
        protected UiPathWebApi(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the UiPathWebApi class.
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
        protected UiPathWebApi(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public UiPathWebApi(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
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
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling UiPathWebApi.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public UiPathWebApi(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
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
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
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
        public UiPathWebApi(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
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
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public UiPathWebApi(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
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
        /// Initializes a new instance of the UiPathWebApi class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
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
        public UiPathWebApi(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
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
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Account = new Account(this);
            Logs = new Logs(this);
            RobotsService = new RobotsService(this);
            Stats = new Stats(this);
            Status = new Status(this);
            Translations = new Translations(this);
            Alerts = new Alerts(this);
            Assets = new Assets(this);
            AuditLogs = new AuditLogs(this);
            Environments = new Environments(this);
            Jobs = new Jobs(this);
            LicensesNamedUser = new LicensesNamedUser(this);
            LicensesRuntime = new LicensesRuntime(this);
            Machines = new Machines(this);
            OrganizationUnits = new OrganizationUnits(this);
            Permissions = new Permissions(this);
            Processes = new Processes(this);
            ProcessSchedules = new ProcessSchedules(this);
            QueueDefinitions = new QueueDefinitions(this);
            QueueItemComments = new QueueItemComments(this);
            QueueItemEvents = new QueueItemEvents(this);
            QueueItems = new QueueItems(this);
            QueueProcessingRecords = new QueueProcessingRecords(this);
            Queues = new Queues(this);
            Releases = new Releases(this);
            RobotLogs = new RobotLogs(this);
            Robots = new Robots(this);
            Roles = new Roles(this);
            Sessions = new Sessions(this);
            Settings = new Settings(this);
            Tenants = new Tenants(this);
            UserLoginAttempts = new UserLoginAttempts(this);
            Users = new Users(this);
            BaseUri = new System.Uri("http://localhost");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
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
        }
    }
}
