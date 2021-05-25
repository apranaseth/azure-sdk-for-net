// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DatabasesOperations operations.
    /// </summary>
    public partial interface IDatabasesOperations
    {
        /// <summary>
        /// Checks that the database name is valid and is not already in use.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckNameResult>> CheckNameAvailabilityWithHttpMessagesAsync(string resourceGroupName, string clusterName, CheckNameRequest resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the list of databases of the given Kusto cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<Database>>> ListByClusterWithHttpMessagesAsync(string resourceGroupName, string clusterName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Database>> GetWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Database>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Database parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the Update operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Database>> UpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Database parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the database with the given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of database principals of the given Kusto cluster
        /// and database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<DatabasePrincipal>>> ListPrincipalsWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add Database principals permissions.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='databasePrincipalsToAdd'>
        /// List of database principals to add.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DatabasePrincipalListResult>> AddPrincipalsWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, DatabasePrincipalListRequest databasePrincipalsToAdd, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove Database principals permissions.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='databasePrincipalsToRemove'>
        /// List of database principals to remove.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<DatabasePrincipalListResult>> RemovePrincipalsWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, DatabasePrincipalListRequest databasePrincipalsToRemove, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Database>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Database parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='parameters'>
        /// The database parameters supplied to the Update operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Database>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Database parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the database with the given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the Kusto cluster.
        /// </param>
        /// <param name='clusterName'>
        /// The name of the Kusto cluster.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database in the Kusto cluster.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string clusterName, string databaseName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
