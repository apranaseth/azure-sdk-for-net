// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableAutomationResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAutomationResourceGroupResource"/> class for mocking. </summary>
        protected MockableAutomationResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAutomationResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAutomationResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AutomationAccountResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AutomationAccountResources and their operations over a AutomationAccountResource. </returns>
        public virtual AutomationAccountCollection GetAutomationAccounts()
        {
            return GetCachedClient(client => new AutomationAccountCollection(client, Id));
        }

        /// <summary>
        /// Get information about an Automation Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AutomationAccountResource>> GetAutomationAccountAsync(string automationAccountName, CancellationToken cancellationToken = default)
        {
            return await GetAutomationAccounts().GetAsync(automationAccountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about an Automation Account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutomationAccount_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-22</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="automationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AutomationAccountResource> GetAutomationAccount(string automationAccountName, CancellationToken cancellationToken = default)
        {
            return GetAutomationAccounts().Get(automationAccountName, cancellationToken);
        }
    }
}
