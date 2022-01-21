using Azure.ResourceManager;
using Azure.ResourceManager.KeyVault;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Authentication;
using Microsoft.Azure.Commands.KeyVault.Models;

using System.Collections.Generic;

namespace Microsoft.Azure.Commands.KeyVault.Track2Models
{
    internal class Track2KeyVaultManagementClient
    {
        private ArmClient _armClient;
        private string _subscription;
        private IClientFactory _clientFactory;

        public Track2KeyVaultManagementClient(IClientFactory clientFactory, IAzureContext context)
        {
            _clientFactory = clientFactory;
            var token = AzureSession.Instance.AuthenticationFactory.Authenticate(
                context.Account, context.Environment, context.Tenant.Id, null, ShowDialog.Never, null);
            _armClient = new ArmClient(new AzureTokenCredential(token.AccessToken, null));
            // _armClient = _clientFactory.CreateArmClient(context, AzureEnvironment.Endpoint.ActiveDirectoryServiceEndpointResourceId);
            _subscription = context.Subscription.Id;
        }

        private ResourceGroup GetResourceGroup(string resourcegroup) =>
            _armClient.GetResourceGroup(new ResourceIdentifier(
                string.Format("/subscriptions/{0}/resourceGroups/{1}", _subscription, resourcegroup)));

        public IEnumerable<Vault> ListVaults(string resourcegroup) =>
            GetResourceGroup(resourcegroup).GetVaults().GetAll();

        public Vault GetVault(string resourcegroup, string vaultName) =>
            _armClient.GetVault(Vault.CreateResourceIdentifier(_subscription, resourcegroup, vaultName));

        public Vault CreateVault(string resourcegroup, string vaultName, VaultCreateOrUpdateParameters parameters) =>
            GetResourceGroup(resourcegroup).GetVaults().CreateOrUpdate(vaultName, parameters).Value;

    }
}