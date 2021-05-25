// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Creates a new managed application definition. </summary>
    public partial class ApplicationDefinitionsCreateOrUpdateOperation : Operation<ApplicationDefinition>, IOperationSource<ApplicationDefinition>
    {
        private readonly ArmOperationHelpers<ApplicationDefinition> _operation;

        /// <summary> Initializes a new instance of ApplicationDefinitionsCreateOrUpdateOperation for mocking. </summary>
        protected ApplicationDefinitionsCreateOrUpdateOperation()
        {
        }

        internal ApplicationDefinitionsCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<ApplicationDefinition>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ApplicationDefinitionsCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ApplicationDefinition Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ApplicationDefinition>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ApplicationDefinition>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ApplicationDefinition IOperationSource<ApplicationDefinition>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ApplicationDefinition.DeserializeApplicationDefinition(document.RootElement);
        }

        async ValueTask<ApplicationDefinition> IOperationSource<ApplicationDefinition>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ApplicationDefinition.DeserializeApplicationDefinition(document.RootElement);
        }
    }
}
