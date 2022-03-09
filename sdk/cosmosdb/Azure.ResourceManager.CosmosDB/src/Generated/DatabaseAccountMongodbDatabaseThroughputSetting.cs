// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a DatabaseAccountMongodbDatabaseThroughputSetting along with the instance operations that can be performed on it. </summary>
    public partial class DatabaseAccountMongodbDatabaseThroughputSetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DatabaseAccountMongodbDatabaseThroughputSetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string databaseName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient;
        private readonly ThroughputSettingsData _data;

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountMongodbDatabaseThroughputSetting"/> class for mocking. </summary>
        protected DatabaseAccountMongodbDatabaseThroughputSetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatabaseAccountMongodbDatabaseThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DatabaseAccountMongodbDatabaseThroughputSetting(ArmClient client, ThroughputSettingsData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseAccountMongodbDatabaseThroughputSetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatabaseAccountMongodbDatabaseThroughputSetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesApiVersion);
            _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(_databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/throughputSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ThroughputSettingsData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the RUs per second of the MongoDB database under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseThroughputSetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the RUs per second of the MongoDB database under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DatabaseAccountMongodbDatabaseThroughputSetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.Get");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update RUs per second of the an Azure Cosmos DB MongoDB database
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_UpdateMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public async virtual Task<ArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>> CreateOrUpdateAsync(bool waitForCompletion, ThroughputSettingsUpdateData updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.UpdateMongoDBDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>(new DatabaseAccountMongodbDatabaseThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.CreateUpdateMongoDBDatabaseThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update RUs per second of the an Azure Cosmos DB MongoDB database
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_UpdateMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="updateThroughputParameters"> The RUs per second of the parameters to provide for the current MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateThroughputParameters"/> is null. </exception>
        public virtual ArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting> CreateOrUpdate(bool waitForCompletion, ThroughputSettingsUpdateData updateThroughputParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(updateThroughputParameters, nameof(updateThroughputParameters));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.UpdateMongoDBDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>(new DatabaseAccountMongodbDatabaseThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.CreateUpdateMongoDBDatabaseThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, updateThroughputParameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB database from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: MongoDBResources_MigrateMongoDBDatabaseToAutoscale
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>> MigrateMongoDBDatabaseToAutoscaleAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.MigrateMongoDBDatabaseToAutoscale");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBDatabaseToAutoscaleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>(new DatabaseAccountMongodbDatabaseThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBDatabaseToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB database from manual throughput to autoscale
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default/migrateToAutoscale
        /// Operation Id: MongoDBResources_MigrateMongoDBDatabaseToAutoscale
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting> MigrateMongoDBDatabaseToAutoscale(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.MigrateMongoDBDatabaseToAutoscale");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBDatabaseToAutoscale(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>(new DatabaseAccountMongodbDatabaseThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBDatabaseToAutoscaleRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB database from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: MongoDBResources_MigrateMongoDBDatabaseToManualThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>> MigrateMongoDBDatabaseToManualThroughputAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.MigrateMongoDBDatabaseToManualThroughput");
            scope.Start();
            try
            {
                var response = await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBDatabaseToManualThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>(new DatabaseAccountMongodbDatabaseThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBDatabaseToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Migrate an Azure Cosmos DB MongoDB database from autoscale to manual throughput
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default/migrateToManualThroughput
        /// Operation Id: MongoDBResources_MigrateMongoDBDatabaseToManualThroughput
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting> MigrateMongoDBDatabaseToManualThroughput(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.MigrateMongoDBDatabaseToManualThroughput");
            scope.Start();
            try
            {
                var response = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.MigrateMongoDBDatabaseToManualThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                var operation = new CosmosDBArmOperation<DatabaseAccountMongodbDatabaseThroughputSetting>(new DatabaseAccountMongodbDatabaseThroughputSettingOperationSource(Client), _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics, Pipeline, _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.CreateMigrateMongoDBDatabaseToManualThroughputRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseThroughputSetting>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<DatabaseAccountMongodbDatabaseThroughputSetting> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseThroughputSetting>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<DatabaseAccountMongodbDatabaseThroughputSetting> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<DatabaseAccountMongodbDatabaseThroughputSetting>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughputAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/throughputSettings/default
        /// Operation Id: MongoDBResources_GetMongoDBDatabaseThroughput
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<DatabaseAccountMongodbDatabaseThroughputSetting> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesClientDiagnostics.CreateScope("DatabaseAccountMongodbDatabaseThroughputSetting.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _databaseAccountMongodbDatabaseThroughputSettingMongoDBResourcesRestClient.GetMongoDBDatabaseThroughput(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                return Response.FromValue(new DatabaseAccountMongodbDatabaseThroughputSetting(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
