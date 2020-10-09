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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> Creates or updates a managed instance administrator. </summary>
    public partial class ManagedInstanceAdministratorsCreateOrUpdateOperation : Operation<ManagedInstanceAdministrator>, IOperationSource<ManagedInstanceAdministrator>
    {
        private readonly ArmOperationHelpers<ManagedInstanceAdministrator> _operation;
        internal ManagedInstanceAdministratorsCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<ManagedInstanceAdministrator>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ManagedInstanceAdministratorsCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagedInstanceAdministrator Value => _operation.Value;

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
        public override ValueTask<Response<ManagedInstanceAdministrator>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagedInstanceAdministrator>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ManagedInstanceAdministrator IOperationSource<ManagedInstanceAdministrator>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ManagedInstanceAdministrator.DeserializeManagedInstanceAdministrator(document.RootElement);
        }

        async ValueTask<ManagedInstanceAdministrator> IOperationSource<ManagedInstanceAdministrator>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ManagedInstanceAdministrator.DeserializeManagedInstanceAdministrator(document.RootElement);
        }
    }
}
