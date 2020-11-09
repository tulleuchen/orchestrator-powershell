// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CredentialStores.
    /// </summary>
    public static partial class CredentialStoresExtensions
    {
            /// <summary>
            /// Gets all Credential Stores.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View or Assets.Create or Assets.Edit or
            /// Assets.View or Robots.Create or Robots.Edit or Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfCredentialStoreDto Get(this ICredentialStores operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all Credential Stores.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View or Assets.Create or Assets.Edit or
            /// Assets.View or Robots.Create or Robots.Edit or Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfCredentialStoreDto> GetAsync(this ICredentialStores operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Credential Store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static CredentialStoreDto Post(this ICredentialStores operations, CredentialStoreDto body = default(CredentialStoreDto))
            {
                return operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Credential Store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CredentialStoreDto> PostAsync(this ICredentialStores operations, CredentialStoreDto body = default(CredentialStoreDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single Credential Store by its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static CredentialStoreDto GetById(this ICredentialStores operations, long key, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(key, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single Credential Store by its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CredentialStoreDto> GetByIdAsync(this ICredentialStores operations, long key, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Credential Store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void PutById(this ICredentialStores operations, long key, CredentialStoreDto body = default(CredentialStoreDto))
            {
                operations.PutByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Credential Store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutByIdAsync(this ICredentialStores operations, long key, CredentialStoreDto body = default(CredentialStoreDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a Credential Store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='forceDelete'>
            /// </param>
            public static void DeleteById(this ICredentialStores operations, long key, bool? forceDelete = default(bool?))
            {
                operations.DeleteByIdAsync(key, forceDelete).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Credential Store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='forceDelete'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this ICredentialStores operations, long key, bool? forceDelete = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, forceDelete, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sets a credential store as the default for the given credential type.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Provides the ID of the credential store to set as default.
            /// </param>
            /// <param name='body'>
            /// Provides the resourceType that indicates
            /// the resource type for which the stores becomes default.
            /// </param>
            public static void SetDefaultStoreForResourceTypeById(this ICredentialStores operations, long key, CredentialStoresSetDefaultStoreForResourceTypeParameters body = default(CredentialStoresSetDefaultStoreForResourceTypeParameters))
            {
                operations.SetDefaultStoreForResourceTypeByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets a credential store as the default for the given credential type.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Write.
            ///
            /// Required permissions: Settings.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Provides the ID of the credential store to set as default.
            /// </param>
            /// <param name='body'>
            /// Provides the resourceType that indicates
            /// the resource type for which the stores becomes default.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetDefaultStoreForResourceTypeByIdAsync(this ICredentialStores operations, long key, CredentialStoresSetDefaultStoreForResourceTypeParameters body = default(CredentialStoresSetDefaultStoreForResourceTypeParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetDefaultStoreForResourceTypeByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets available Credential Store types.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfString GetAvailableCredentialStoreTypes(this ICredentialStores operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?))
            {
                return operations.GetAvailableCredentialStoreTypesAsync(expand, filter, select, orderby, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets available Credential Store types.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfString> GetAvailableCredentialStoreTypesAsync(this ICredentialStores operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableCredentialStoreTypesWithHttpMessagesAsync(expand, filter, select, orderby, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the default credential store for the given resource type.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View or Assets.Create or Assets.Edit or
            /// Assets.View or Robots.Create or Robots.Edit or Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceType'>
            /// Provides the resource type for which to retrieve the default. Possible
            /// values include: 'AssetCredential', 'RobotCredential', 'BucketCredential',
            /// 'Secrets'
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static ODataValueOfInt64 GetDefaultStoreForResourceTypeByResourcetype(this ICredentialStores operations, CredentialStoreResourceType resourceType, string expand = default(string), string select = default(string))
            {
                return operations.GetDefaultStoreForResourceTypeByResourcetypeAsync(resourceType, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the default credential store for the given resource type.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View or Assets.Create or Assets.Edit or
            /// Assets.View or Robots.Create or Robots.Edit or Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceType'>
            /// Provides the resource type for which to retrieve the default. Possible
            /// values include: 'AssetCredential', 'RobotCredential', 'BucketCredential',
            /// 'Secrets'
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfInt64> GetDefaultStoreForResourceTypeByResourcetypeAsync(this ICredentialStores operations, CredentialStoreResourceType resourceType, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDefaultStoreForResourceTypeByResourcetypeWithHttpMessagesAsync(resourceType, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets available resources robots (and later assets) for a credential store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Provides the ID of the credential store for which to retrieve resources.
            /// </param>
            /// <param name='resourceType'>
            /// Possible values include: 'AssetCredential', 'RobotCredential',
            /// 'BucketCredential', 'Secrets'
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfCredentialStoreResourceDto GetResourcesForCredentialStoreTypesByKeyAndResourcetype(this ICredentialStores operations, long key, CredentialStoreResourceType resourceType, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetResourcesForCredentialStoreTypesByKeyAndResourcetypeAsync(key, resourceType, expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets available resources robots (and later assets) for a credential store.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Settings or Settings.Read.
            ///
            /// Required permissions: Settings.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Provides the ID of the credential store for which to retrieve resources.
            /// </param>
            /// <param name='resourceType'>
            /// Possible values include: 'AssetCredential', 'RobotCredential',
            /// 'BucketCredential', 'Secrets'
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfCredentialStoreResourceDto> GetResourcesForCredentialStoreTypesByKeyAndResourcetypeAsync(this ICredentialStores operations, long key, CredentialStoreResourceType resourceType, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourcesForCredentialStoreTypesByKeyAndResourcetypeWithHttpMessagesAsync(key, resourceType, expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
