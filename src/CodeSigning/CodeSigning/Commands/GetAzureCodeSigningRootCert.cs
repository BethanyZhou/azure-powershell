﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.CodeSigning.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Azure.Commands.CodeSigning
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzurePrefix + "CodeSigningRootCert", DefaultParameterSetName = ByAccountProfileNameParameterSet)]
    [OutputType(typeof(string))]
    public class GetAzureCodeSigningRootCert : CodeSigningCmdletBase
    {
        #region Parameter Set Names

        private const string ByAccountProfileNameParameterSet = "ByAccountProfileNameParameterSet";
        private const string ByMetadataFileParameterSet = "ByMetadataFileParameterSet";

        #endregion

        #region Input Parameter Definitions

        /// <summary>
        /// Account Profile name
        /// </summary>
        [Parameter(Mandatory = true,
            Position = 0,
            ParameterSetName = ByAccountProfileNameParameterSet,
            HelpMessage = "Account Profile name. Cmdlet constructs the FQDN of an account profile based on the name and currently selected environment.")]       
        [ResourceNameCompleter("Microsoft.CodeSigning/certs", "FakeResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string AccountName { get; set; }
        public string ProfileName { get; set; }
        public string EndpointUrl { get; set; }


        /// <summary>
        /// Metadata File Path
        /// </summary>
        [Parameter(Mandatory = true,
            Position = 0,
            ParameterSetName = ByMetadataFileParameterSet,
            HelpMessage = "Metadata File path. Cmdlet constructs the FQDN of an account profile based on the Metadata File and currently selected environment.")]
        [ResourceNameCompleter("Microsoft.CodeSigning/certs", "FakeResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string MetadatFilePath { get; set; }
               
        #endregion

        public override void ExecuteCmdlet()
        {
            byte[] rootcert;

            if (!string.IsNullOrEmpty(AccountName))
            {
                rootcert = CodeSigningServiceClient.GetCodeSigningRootCert(AccountName, ProfileName, EndpointUrl);
                WriteRootCert(rootcert);
            }          
            else if (!string.IsNullOrEmpty(MetadatFilePath))
            {
                rootcert = CodeSigningServiceClient.GetCodeSigningRootCert(MetadatFilePath);
                WriteRootCert(rootcert);            
            }
        }
        private void WriteRootCert(byte[] rootcert)
        {  
            WriteObject(rootcert);         
        }      
    }
}
