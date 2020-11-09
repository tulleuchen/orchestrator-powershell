// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OrganizationUnits operations.
    /// </summary>
    public partial interface IOrganizationUnits
    {
        /// <summary>
        /// Gets the organization units.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Read.
        ///
        /// Required permissions: Units.View.
        ///
        /// DEPRECATED: Use /Folders/GetFolders instead.
        /// </remarks>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='top'>
        /// Limits the number of items returned from a collection. The maximum
        /// value is 1000.
        /// </param>
        /// <param name='skip'>
        /// Excludes the specified number of items of the queried collection
        /// from the result.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfOrganizationUnitDto>> GetWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an organization unit.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Write.
        ///
        /// Required permissions: Units.Create.
        ///
        /// DEPRECATED: Use /Folders/Post instead.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<OrganizationUnitDto>> PostWithHttpMessagesAsync(OrganizationUnitDto body = default(OrganizationUnitDto), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets an organization unit.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Read.
        ///
        /// Required permissions: Units.View.
        ///
        /// DEPRECATED: Use /Folders/Get instead.
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<OrganizationUnitDto>> GetByIdWithHttpMessagesAsync(long key, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Edits an organization unit.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Write.
        ///
        /// Required permissions: Units.Edit.
        ///
        /// DEPRECATED: Use /Folders/Put instead.
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<OrganizationUnitDto>> PutByIdWithHttpMessagesAsync(int key, OrganizationUnitDto body = default(OrganizationUnitDto), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an organization unit.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Write.
        ///
        /// Required permissions: Units.Delete.
        ///
        /// DEPRECATED: Use /Folders/Delete instead.
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(long key, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Associates a group of users with and dissociates another group of
        /// users from the given unit.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Write.
        ///
        /// Required permissions: Users.Edit.
        ///
        /// DEPRECATED: Use /Folders/AssignUsers instead.
        /// </remarks>
        /// <param name='key'>
        /// The unit id.
        /// </param>
        /// <param name='body'>
        /// &lt;para /&gt;addedUserIds - The id of the users to be associated
        /// with the unit.
        /// &lt;para /&gt;removedUserIds - The id of the users to be
        /// dissociated from the unit.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse> SetUsersByIdWithHttpMessagesAsync(int key, OrganizationUnitsSetUsersParameters body = default(OrganizationUnitsSetUsersParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a collection of all the ids of the users associated to an
        /// unit based on unit Id.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Read.
        ///
        /// Required permissions: Units.View and Users.View.
        ///
        /// DEPRECATED: Kept for backwards compatibility.
        /// </remarks>
        /// <param name='key'>
        /// The Id of the unit for which the robot ids are fetched.
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfInt64>> GetUserIdsForUnitByKeyWithHttpMessagesAsync(long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a collection of all non robot users and, if no other
        /// sorting is provided, will place first those associated to an unit.
        /// Allows odata query options.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Folders or
        /// Folders.Read.
        ///
        /// Required permissions: Units.View and Users.View.
        ///
        /// DEPRECATED: Use /Folders/GetUsersForFolder instead.
        /// </remarks>
        /// <param name='key'>
        /// The Id of the unit for which the associated users are placed first.
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='top'>
        /// Limits the number of items returned from a collection. The maximum
        /// value is 1000.
        /// </param>
        /// <param name='skip'>
        /// Excludes the specified number of items of the queried collection
        /// from the result.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfUserDto>> GetUsersForUnitByKeyWithHttpMessagesAsync(long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
