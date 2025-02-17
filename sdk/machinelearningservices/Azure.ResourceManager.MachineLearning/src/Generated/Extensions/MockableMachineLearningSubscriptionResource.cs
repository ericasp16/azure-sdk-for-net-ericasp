// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableMachineLearningSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;
        private ClientDiagnostics _virtualMachineSizesClientDiagnostics;
        private VirtualMachineSizesRestOperations _virtualMachineSizesRestClient;
        private ClientDiagnostics _quotasClientDiagnostics;
        private QuotasRestOperations _quotasRestClient;
        private ClientDiagnostics _machineLearningRegistryRegistriesClientDiagnostics;
        private RegistriesRestOperations _machineLearningRegistryRegistriesRestClient;
        private ClientDiagnostics _machineLearningWorkspaceWorkspacesClientDiagnostics;
        private WorkspacesRestOperations _machineLearningWorkspaceWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableMachineLearningSubscriptionResource"/> class for mocking. </summary>
        protected MockableMachineLearningSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMachineLearningSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMachineLearningSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics VirtualMachineSizesClientDiagnostics => _virtualMachineSizesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private VirtualMachineSizesRestOperations VirtualMachineSizesRestClient => _virtualMachineSizesRestClient ??= new VirtualMachineSizesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics QuotasClientDiagnostics => _quotasClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private QuotasRestOperations QuotasRestClient => _quotasRestClient ??= new QuotasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics MachineLearningRegistryRegistriesClientDiagnostics => _machineLearningRegistryRegistriesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningRegistryResource.ResourceType.Namespace, Diagnostics);
        private RegistriesRestOperations MachineLearningRegistryRegistriesRestClient => _machineLearningRegistryRegistriesRestClient ??= new RegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MachineLearningRegistryResource.ResourceType));
        private ClientDiagnostics MachineLearningWorkspaceWorkspacesClientDiagnostics => _machineLearningWorkspaceWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningWorkspaceResource.ResourceType.Namespace, Diagnostics);
        private WorkspacesRestOperations MachineLearningWorkspaceWorkspacesRestClient => _machineLearningWorkspaceWorkspacesRestClient ??= new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MachineLearningWorkspaceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the current usage information as well as limits for AML resources for given subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningUsage> GetMachineLearningUsagesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => MachineLearningUsage.DeserializeMachineLearningUsage(e), UsagesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the current usage information as well as limits for AML resources for given subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningUsage> GetMachineLearningUsages(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => MachineLearningUsage.DeserializeMachineLearningUsage(e), UsagesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns supported VM Sizes in a location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/vmSizes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSizes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningVmSize"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningVmSize> GetMachineLearningVmSizesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualMachineSizesRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => MachineLearningVmSize.DeserializeMachineLearningVmSize(e), VirtualMachineSizesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningVmSizes", "value", null, cancellationToken);
        }

        /// <summary>
        /// Returns supported VM Sizes in a location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/vmSizes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineSizes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningVmSize"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningVmSize> GetMachineLearningVmSizes(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualMachineSizesRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => MachineLearningVmSize.DeserializeMachineLearningVmSize(e), VirtualMachineSizesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningVmSizes", "value", null, cancellationToken);
        }

        /// <summary>
        /// Update quota for each VM family in workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/updateQuotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for update quota is queried. </param>
        /// <param name="content"> Quota update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="MachineLearningWorkspaceQuotaUpdate"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningWorkspaceQuotaUpdate> UpdateMachineLearningQuotasAsync(AzureLocation location, MachineLearningQuotaUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => QuotasRestClient.CreateUpdateRequest(Id.SubscriptionId, location, content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => MachineLearningWorkspaceQuotaUpdate.DeserializeMachineLearningWorkspaceQuotaUpdate(e), QuotasClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.UpdateMachineLearningQuotas", "value", null, cancellationToken);
        }

        /// <summary>
        /// Update quota for each VM family in workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/updateQuotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for update quota is queried. </param>
        /// <param name="content"> Quota update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="MachineLearningWorkspaceQuotaUpdate"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningWorkspaceQuotaUpdate> UpdateMachineLearningQuotas(AzureLocation location, MachineLearningQuotaUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => QuotasRestClient.CreateUpdateRequest(Id.SubscriptionId, location, content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => MachineLearningWorkspaceQuotaUpdate.DeserializeMachineLearningWorkspaceQuotaUpdate(e), QuotasClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.UpdateMachineLearningQuotas", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the currently assigned Workspace Quotas based on VMFamily.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningResourceQuota"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningResourceQuota> GetMachineLearningQuotasAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QuotasRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QuotasRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => MachineLearningResourceQuota.DeserializeMachineLearningResourceQuota(e), QuotasClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningQuotas", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the currently assigned Workspace Quotas based on VMFamily.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/locations/{location}/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location for which resource usage is queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningResourceQuota"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningResourceQuota> GetMachineLearningQuotas(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QuotasRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QuotasRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => MachineLearningResourceQuota.DeserializeMachineLearningResourceQuota(e), QuotasClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningQuotas", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List registries by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/registries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningRegistryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningRegistryResource> GetMachineLearningRegistriesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MachineLearningRegistryRegistriesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MachineLearningRegistryRegistriesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryResource(Client, MachineLearningRegistryData.DeserializeMachineLearningRegistryData(e)), MachineLearningRegistryRegistriesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningRegistries", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List registries by subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/registries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningRegistryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningRegistryResource> GetMachineLearningRegistries(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MachineLearningRegistryRegistriesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MachineLearningRegistryRegistriesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryResource(Client, MachineLearningRegistryData.DeserializeMachineLearningRegistryData(e)), MachineLearningRegistryRegistriesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningRegistries", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available machine learning workspaces under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="kind"> Kind of workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningWorkspaceResource> GetMachineLearningWorkspacesAsync(string skip = null, string kind = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MachineLearningWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skip, kind);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MachineLearningWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skip, kind);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningWorkspaceResource(Client, MachineLearningWorkspaceData.DeserializeMachineLearningWorkspaceData(e)), MachineLearningWorkspaceWorkspacesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningWorkspaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available machine learning workspaces under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningServices/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="kind"> Kind of workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningWorkspaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningWorkspaceResource> GetMachineLearningWorkspaces(string skip = null, string kind = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MachineLearningWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, skip, kind);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MachineLearningWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, skip, kind);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningWorkspaceResource(Client, MachineLearningWorkspaceData.DeserializeMachineLearningWorkspaceData(e)), MachineLearningWorkspaceWorkspacesClientDiagnostics, Pipeline, "MockableMachineLearningSubscriptionResource.GetMachineLearningWorkspaces", "value", "nextLink", cancellationToken);
        }
    }
}
