// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A Class representing a NamespaceQueueAuthorizationRule along with the instance operations that can be performed on it. </summary>
    public partial class NamespaceQueueAuthorizationRule : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NamespaceQueueAuthorizationRule"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly QueueAuthorizationRulesRestOperations _queueAuthorizationRulesRestClient;
        private readonly ServiceBusAuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRule"/> class for mocking. </summary>
        protected NamespaceQueueAuthorizationRule()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NamespaceQueueAuthorizationRule"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRule(ArmResource options, ServiceBusAuthorizationRuleData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _queueAuthorizationRulesRestClient = new QueueAuthorizationRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRule"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRule(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _queueAuthorizationRulesRestClient = new QueueAuthorizationRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRule"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRule(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _queueAuthorizationRulesRestClient = new QueueAuthorizationRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/queues/authorizationRules";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusAuthorizationRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets an authorization rule for a queue by rule name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<NamespaceQueueAuthorizationRule>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Get");
            scope.Start();
            try
            {
                var response = await _queueAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NamespaceQueueAuthorizationRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an authorization rule for a queue by rule name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NamespaceQueueAuthorizationRule> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Get");
            scope.Start();
            try
            {
                var response = _queueAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceQueueAuthorizationRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes a queue authorization rule. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<QueueAuthorizationRuleDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Delete");
            scope.Start();
            try
            {
                var response = await _queueAuthorizationRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new QueueAuthorizationRuleDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a queue authorization rule. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual QueueAuthorizationRuleDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.Delete");
            scope.Start();
            try
            {
                var response = _queueAuthorizationRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new QueueAuthorizationRuleDeleteOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Primary and secondary connection strings to the queue. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<AccessKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.GetKeys");
            scope.Start();
            try
            {
                var response = await _queueAuthorizationRulesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Primary and secondary connection strings to the queue. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AccessKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.GetKeys");
            scope.Start();
            try
            {
                var response = _queueAuthorizationRulesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerates the primary or secondary connection strings to the queue. </summary>
        /// <param name="parameters"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<AccessKeys>> RegenerateKeysAsync(RegenerateAccessKeyOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _queueAuthorizationRulesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerates the primary or secondary connection strings to the queue. </summary>
        /// <param name="parameters"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<AccessKeys> RegenerateKeys(RegenerateAccessKeyOptions parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceQueueAuthorizationRule.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _queueAuthorizationRulesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
