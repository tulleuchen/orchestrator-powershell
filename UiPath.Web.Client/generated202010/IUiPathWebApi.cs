// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Orchestrator API
    /// </summary>
    public partial interface IUiPathWebApi : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccount.
        /// </summary>
        IAccount Account { get; }

        /// <summary>
        /// Gets the IToken.
        /// </summary>
        IToken Token { get; }

        /// <summary>
        /// Gets the IDirectoryService.
        /// </summary>
        IDirectoryService DirectoryService { get; }

        /// <summary>
        /// Gets the IFoldersNavigation.
        /// </summary>
        IFoldersNavigation FoldersNavigation { get; }

        /// <summary>
        /// Gets the ILicensing.
        /// </summary>
        ILicensing Licensing { get; }

        /// <summary>
        /// Gets the ILogs.
        /// </summary>
        ILogs Logs { get; }

        /// <summary>
        /// Gets the IMaintenance.
        /// </summary>
        IMaintenance Maintenance { get; }

        /// <summary>
        /// Gets the IRobotsService.
        /// </summary>
        IRobotsService RobotsService { get; }

        /// <summary>
        /// Gets the IStats.
        /// </summary>
        IStats Stats { get; }

        /// <summary>
        /// Gets the IStatus.
        /// </summary>
        IStatus Status { get; }

        /// <summary>
        /// Gets the ITestAutomation.
        /// </summary>
        ITestAutomation TestAutomation { get; }

        /// <summary>
        /// Gets the ITestDataQueueActions.
        /// </summary>
        ITestDataQueueActions TestDataQueueActions { get; }

        /// <summary>
        /// Gets the ITranslations.
        /// </summary>
        ITranslations Translations { get; }

        /// <summary>
        /// Gets the ITaskForms.
        /// </summary>
        ITaskForms TaskForms { get; }

        /// <summary>
        /// Gets the IAlerts.
        /// </summary>
        IAlerts Alerts { get; }

        /// <summary>
        /// Gets the IAssets.
        /// </summary>
        IAssets Assets { get; }

        /// <summary>
        /// Gets the IAuditLogs.
        /// </summary>
        IAuditLogs AuditLogs { get; }

        /// <summary>
        /// Gets the IBuckets.
        /// </summary>
        IBuckets Buckets { get; }

        /// <summary>
        /// Gets the ICalendars.
        /// </summary>
        ICalendars Calendars { get; }

        /// <summary>
        /// Gets the ICredentialStores.
        /// </summary>
        ICredentialStores CredentialStores { get; }

        /// <summary>
        /// Gets the IEnvironments.
        /// </summary>
        IEnvironments Environments { get; }

        /// <summary>
        /// Gets the IExecutionMedia.
        /// </summary>
        IExecutionMedia ExecutionMedia { get; }

        /// <summary>
        /// Gets the IFolders.
        /// </summary>
        IFolders Folders { get; }

        /// <summary>
        /// Gets the IHostLicenses.
        /// </summary>
        IHostLicenses HostLicenses { get; }

        /// <summary>
        /// Gets the IJobs.
        /// </summary>
        IJobs Jobs { get; }

        /// <summary>
        /// Gets the IJobTriggers.
        /// </summary>
        IJobTriggers JobTriggers { get; }

        /// <summary>
        /// Gets the ILibraries.
        /// </summary>
        ILibraries Libraries { get; }

        /// <summary>
        /// Gets the ILicensesNamedUser.
        /// </summary>
        ILicensesNamedUser LicensesNamedUser { get; }

        /// <summary>
        /// Gets the ILicensesRuntime.
        /// </summary>
        ILicensesRuntime LicensesRuntime { get; }

        /// <summary>
        /// Gets the IMachines.
        /// </summary>
        IMachines Machines { get; }

        /// <summary>
        /// Gets the IMessageTemplates.
        /// </summary>
        IMessageTemplates MessageTemplates { get; }

        /// <summary>
        /// Gets the IOrganizationUnits.
        /// </summary>
        IOrganizationUnits OrganizationUnits { get; }

        /// <summary>
        /// Gets the IPermissions.
        /// </summary>
        IPermissions Permissions { get; }

        /// <summary>
        /// Gets the IProcesses.
        /// </summary>
        IProcesses Processes { get; }

        /// <summary>
        /// Gets the IProcessSchedules.
        /// </summary>
        IProcessSchedules ProcessSchedules { get; }

        /// <summary>
        /// Gets the IQueueDefinitions.
        /// </summary>
        IQueueDefinitions QueueDefinitions { get; }

        /// <summary>
        /// Gets the IQueueItemComments.
        /// </summary>
        IQueueItemComments QueueItemComments { get; }

        /// <summary>
        /// Gets the IQueueItemEvents.
        /// </summary>
        IQueueItemEvents QueueItemEvents { get; }

        /// <summary>
        /// Gets the IQueueItems.
        /// </summary>
        IQueueItems QueueItems { get; }

        /// <summary>
        /// Gets the IQueueProcessingRecords.
        /// </summary>
        IQueueProcessingRecords QueueProcessingRecords { get; }

        /// <summary>
        /// Gets the IQueues.
        /// </summary>
        IQueues Queues { get; }

        /// <summary>
        /// Gets the IReleases.
        /// </summary>
        IReleases Releases { get; }

        /// <summary>
        /// Gets the IRobotLogs.
        /// </summary>
        IRobotLogs RobotLogs { get; }

        /// <summary>
        /// Gets the IRobots.
        /// </summary>
        IRobots Robots { get; }

        /// <summary>
        /// Gets the IRoles.
        /// </summary>
        IRoles Roles { get; }

        /// <summary>
        /// Gets the ISessions.
        /// </summary>
        ISessions Sessions { get; }

        /// <summary>
        /// Gets the ISettings.
        /// </summary>
        ISettings Settings { get; }

        /// <summary>
        /// Gets the ITaskActivities.
        /// </summary>
        ITaskActivities TaskActivities { get; }

        /// <summary>
        /// Gets the ITaskCatalogs.
        /// </summary>
        ITaskCatalogs TaskCatalogs { get; }

        /// <summary>
        /// Gets the ITaskNotes.
        /// </summary>
        ITaskNotes TaskNotes { get; }

        /// <summary>
        /// Gets the ITasks.
        /// </summary>
        ITasks Tasks { get; }

        /// <summary>
        /// Gets the ITenants.
        /// </summary>
        ITenants Tenants { get; }

        /// <summary>
        /// Gets the ITestCaseDefinitions.
        /// </summary>
        ITestCaseDefinitions TestCaseDefinitions { get; }

        /// <summary>
        /// Gets the ITestCaseExecutions.
        /// </summary>
        ITestCaseExecutions TestCaseExecutions { get; }

        /// <summary>
        /// Gets the ITestDataQueueItems.
        /// </summary>
        ITestDataQueueItems TestDataQueueItems { get; }

        /// <summary>
        /// Gets the ITestDataQueues.
        /// </summary>
        ITestDataQueues TestDataQueues { get; }

        /// <summary>
        /// Gets the ITestSetExecutions.
        /// </summary>
        ITestSetExecutions TestSetExecutions { get; }

        /// <summary>
        /// Gets the ITestSets.
        /// </summary>
        ITestSets TestSets { get; }

        /// <summary>
        /// Gets the ITestSetSchedules.
        /// </summary>
        ITestSetSchedules TestSetSchedules { get; }

        /// <summary>
        /// Gets the IUserLoginAttempts.
        /// </summary>
        IUserLoginAttempts UserLoginAttempts { get; }

        /// <summary>
        /// Gets the IUsers.
        /// </summary>
        IUsers Users { get; }

        /// <summary>
        /// Gets the IWebhooks.
        /// </summary>
        IWebhooks Webhooks { get; }

        /// <summary>
        /// Gets the IGenericTasks.
        /// </summary>
        IGenericTasks GenericTasks { get; }

    }
}
