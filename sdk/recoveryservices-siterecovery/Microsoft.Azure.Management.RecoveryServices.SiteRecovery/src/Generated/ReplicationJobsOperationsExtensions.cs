// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationJobsOperations.
    /// </summary>
    public static partial class ReplicationJobsOperationsExtensions
    {
            /// <summary>
            /// Gets the list of jobs.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery Jobs for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Job> List(this IReplicationJobsOperations operations, ODataQuery<JobQueryParameter> odataQuery = default(ODataQuery<JobQueryParameter>))
            {
                return operations.ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of jobs.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery Jobs for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Job>> ListAsync(this IReplicationJobsOperations operations, ODataQuery<JobQueryParameter> odataQuery = default(ODataQuery<JobQueryParameter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the job details.
            /// </summary>
            /// <remarks>
            /// Get the details of an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            public static Job Get(this IReplicationJobsOperations operations, string jobName)
            {
                return operations.GetAsync(jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the job details.
            /// </summary>
            /// <remarks>
            /// Get the details of an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> GetAsync(this IReplicationJobsOperations operations, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to cancel an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            public static Job Cancel(this IReplicationJobsOperations operations, string jobName)
            {
                return operations.CancelAsync(jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to cancel an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> CancelAsync(this IReplicationJobsOperations operations, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelWithHttpMessagesAsync(jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restarts the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to restart an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            public static Job Restart(this IReplicationJobsOperations operations, string jobName)
            {
                return operations.RestartAsync(jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to restart an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> RestartAsync(this IReplicationJobsOperations operations, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RestartWithHttpMessagesAsync(jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resumes the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to resume an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='resumeJobParams'>
            /// Resume rob comments.
            /// </param>
            public static Job Resume(this IReplicationJobsOperations operations, string jobName, ResumeJobParams resumeJobParams)
            {
                return operations.ResumeAsync(jobName, resumeJobParams).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resumes the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to resume an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='resumeJobParams'>
            /// Resume rob comments.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> ResumeAsync(this IReplicationJobsOperations operations, string jobName, ResumeJobParams resumeJobParams, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ResumeWithHttpMessagesAsync(jobName, resumeJobParams, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports the details of the Azure Site Recovery jobs of the vault.
            /// </summary>
            /// <remarks>
            /// The operation to export the details of the Azure Site Recovery jobs of the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobQueryParameter'>
            /// job query filter.
            /// </param>
            public static Job Export(this IReplicationJobsOperations operations, JobQueryParameter jobQueryParameter)
            {
                return operations.ExportAsync(jobQueryParameter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports the details of the Azure Site Recovery jobs of the vault.
            /// </summary>
            /// <remarks>
            /// The operation to export the details of the Azure Site Recovery jobs of the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobQueryParameter'>
            /// job query filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> ExportAsync(this IReplicationJobsOperations operations, JobQueryParameter jobQueryParameter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportWithHttpMessagesAsync(jobQueryParameter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to cancel an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            public static Job BeginCancel(this IReplicationJobsOperations operations, string jobName)
            {
                return operations.BeginCancelAsync(jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to cancel an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> BeginCancelAsync(this IReplicationJobsOperations operations, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCancelWithHttpMessagesAsync(jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restarts the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to restart an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            public static Job BeginRestart(this IReplicationJobsOperations operations, string jobName)
            {
                return operations.BeginRestartAsync(jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restarts the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to restart an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> BeginRestartAsync(this IReplicationJobsOperations operations, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRestartWithHttpMessagesAsync(jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resumes the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to resume an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='resumeJobParams'>
            /// Resume rob comments.
            /// </param>
            public static Job BeginResume(this IReplicationJobsOperations operations, string jobName, ResumeJobParams resumeJobParams)
            {
                return operations.BeginResumeAsync(jobName, resumeJobParams).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resumes the specified job.
            /// </summary>
            /// <remarks>
            /// The operation to resume an Azure Site Recovery job.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// Job identifier.
            /// </param>
            /// <param name='resumeJobParams'>
            /// Resume rob comments.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> BeginResumeAsync(this IReplicationJobsOperations operations, string jobName, ResumeJobParams resumeJobParams, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginResumeWithHttpMessagesAsync(jobName, resumeJobParams, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports the details of the Azure Site Recovery jobs of the vault.
            /// </summary>
            /// <remarks>
            /// The operation to export the details of the Azure Site Recovery jobs of the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobQueryParameter'>
            /// job query filter.
            /// </param>
            public static Job BeginExport(this IReplicationJobsOperations operations, JobQueryParameter jobQueryParameter)
            {
                return operations.BeginExportAsync(jobQueryParameter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports the details of the Azure Site Recovery jobs of the vault.
            /// </summary>
            /// <remarks>
            /// The operation to export the details of the Azure Site Recovery jobs of the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobQueryParameter'>
            /// job query filter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> BeginExportAsync(this IReplicationJobsOperations operations, JobQueryParameter jobQueryParameter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginExportWithHttpMessagesAsync(jobQueryParameter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of jobs.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery Jobs for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Job> ListNext(this IReplicationJobsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of jobs.
            /// </summary>
            /// <remarks>
            /// Gets the list of Azure Site Recovery Jobs for the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Job>> ListNextAsync(this IReplicationJobsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
