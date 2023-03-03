
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for SweepJob.
.Description
Create an in-memory object for SweepJob.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SweepJob
.Link
https://learn.microsoft.com/powershell/module/az.MachineLearningServices/new-AzMLWorkspaceSweepJobObject
#>
function New-AzMLWorkspaceSweepJobObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SweepJob')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="[Required] Specifies the type of distribution framework.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DistributionType])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DistributionType]
        $DistributionType,
        [Parameter(HelpMessage="Number of intervals by which to delay the first evaluation.")]
        [int]
        $EarlyTerminationDelayEvaluation,
        [Parameter(HelpMessage="Interval (number of runs) between policy evaluations.")]
        [int]
        $EarlyTerminationEvaluationInterval,
        [Parameter(HelpMessage="[Required] Name of policy configuration.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EarlyTerminationPolicyType])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EarlyTerminationPolicyType]
        $EarlyTerminationPolicyType,
        [Parameter(HelpMessage="Mapping of input data bindings used in the job.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobInputs]
        $JobInput,
        [Parameter(HelpMessage="Sweep Job max concurrent trials.")]
        [int]
        $LimitMaxConcurrentTrial,
        [Parameter(HelpMessage="Sweep Job max total trials.")]
        [int]
        $LimitMaxTotalTrial,
        [Parameter(HelpMessage="The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds.")]
        [System.TimeSpan]
        $LimitTimeout,
        [Parameter(HelpMessage="Sweep Job Trial timeout value.")]
        [System.TimeSpan]
        $LimitTrialTimeout,
        [Parameter(Mandatory, HelpMessage="[Required] Defines supported metric goals for hyperparameter tuning.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.Goal])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.Goal]
        $ObjectiveGoal,
        [Parameter(Mandatory, HelpMessage="[Required] Name of the metric to optimize.")]
        [string]
        $ObjectivePrimaryMetric,
        [Parameter(HelpMessage="Mapping of output data bindings used in the job.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobOutputs]
        $JobOutput,
        [Parameter(HelpMessage="Optional number of instances or nodes used by the compute target.")]
        [int]
        $ResourceInstanceCount,
        [Parameter(HelpMessage="Optional type of VM used as supported by the compute target.")]
        [string]
        $ResourceInstanceType,
        [Parameter(HelpMessage="Additional properties bag.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceConfigurationProperties]
        $ResourceProperty,
        [Parameter(Mandatory, HelpMessage="[Required] The algorithm used for generating hyperparameter values, along with configuration properties.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SamplingAlgorithmType])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SamplingAlgorithmType]
        $SamplingAlgorithmType,
        [Parameter(Mandatory, HelpMessage="[Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny]
        $SearchSpace,
        [Parameter(HelpMessage="ARM resource ID of the code asset.")]
        [string]
        $TrialCodeId,
        [Parameter(Mandatory, HelpMessage="[Required] The command to execute on startup of the job. eg. `"python train.py`".")]
        [string]
        $TrialCommand,
        [Parameter(Mandatory, HelpMessage="[Required] The ARM resource ID of the Environment specification for the job.")]
        [string]
        $TrialEnvironmentId,
        [Parameter(HelpMessage="Environment variables included in the job.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ITrialComponentEnvironmentVariables]
        $TrialEnvironmentVariable,
        [Parameter(HelpMessage="ARM resource ID of the compute resource.")]
        [string]
        $ComputeId,
        [Parameter(HelpMessage="Display name of job.")]
        [string]
        $DisplayName,
        [Parameter(HelpMessage="The name of the experiment the job belongs to. If not set, the job is placed in the `"Default`" experiment.")]
        [string]
        $ExperimentName,
        [Parameter(HelpMessage="[Required] Specifies the type of identity framework.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType]
        $IdentityType,
        [Parameter(HelpMessage="Is the asset archived?.")]
        [bool]
        $IsArchived,
        # [Parameter(HelpMessage="List of JobEndpoints.
        # For local jobs, a job endpoint will have an endpoint value of FileStreamObject.")]
        # [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices]
        # $Service,
        [Parameter(HelpMessage="Url for endpoint.")]
        [string]
        $ServiceEndpoint,
        [Parameter(HelpMessage="Port for endpoint.")]
        [int]
        $ServicePort,
        [Parameter(HelpMessage="Additional properties to set on the endpoint.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobServiceProperties]
        $ServiceProperty,
        [Parameter(HelpMessage="Endpoint type.")]
        [string]
        $ServiceType,

        [Parameter(HelpMessage="The asset description text.")]
        [string]
        $Description,
        [Parameter(HelpMessage="The asset property dictionary.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseProperties]
        $Property,
        [Parameter(HelpMessage="Tag dictionary. Tags can be added, removed, and updated.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseTags]
        $Tag
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SweepJob]::New()
        $Object.JobType = 'Sweep'
        $Object.LimitJobLimitsType = 'Sweep' # Required define in swagger.
        $Service = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseServices]::New()

        if ($PSBoundParameters.ContainsKey('DistributionType')) {
            $Object.DistributionType = $DistributionType
        }
        if ($PSBoundParameters.ContainsKey('EarlyTerminationDelayEvaluation')) {
            $Object.EarlyTerminationDelayEvaluation = $EarlyTerminationDelayEvaluation
        }
        if ($PSBoundParameters.ContainsKey('EarlyTerminationEvaluationInterval')) {
            $Object.EarlyTerminationEvaluationInterval = $EarlyTerminationEvaluationInterval
        }
        if ($PSBoundParameters.ContainsKey('EarlyTerminationPolicyType')) {
            $Object.EarlyTerminationPolicyType = $EarlyTerminationPolicyType
        }
        if ($PSBoundParameters.ContainsKey('JobInput')) {
            $Object.Input = $JobInput
        }
        if ($PSBoundParameters.ContainsKey('LimitMaxConcurrentTrial')) {
            $Object.LimitMaxConcurrentTrial = $LimitMaxConcurrentTrial
        }
        if ($PSBoundParameters.ContainsKey('LimitMaxTotalTrial')) {
            $Object.LimitMaxTotalTrial = $LimitMaxTotalTrial
        }
        if ($PSBoundParameters.ContainsKey('LimitTimeout')) {
            $Object.LimitTimeout = $LimitTimeout
        }
        if ($PSBoundParameters.ContainsKey('LimitTrialTimeout')) {
            $Object.LimitTrialTimeout = $LimitTrialTimeout
        }
        if ($PSBoundParameters.ContainsKey('ObjectiveGoal')) {
            $Object.ObjectiveGoal = $ObjectiveGoal
        }
        if ($PSBoundParameters.ContainsKey('ObjectivePrimaryMetric')) {
            $Object.ObjectivePrimaryMetric = $ObjectivePrimaryMetric
        }
        if ($PSBoundParameters.ContainsKey('JobOutput')) {
            $Object.Output = $JobOutput
        }
        if ($PSBoundParameters.ContainsKey('ResourceInstanceCount')) {
            $Object.ResourceInstanceCount = $ResourceInstanceCount
        }
        if ($PSBoundParameters.ContainsKey('ResourceInstanceType')) {
            $Object.ResourceInstanceType = $ResourceInstanceType
        }
        if ($PSBoundParameters.ContainsKey('ResourceProperty')) {
            $Object.ResourceProperty = $ResourceProperty
        }
        if ($PSBoundParameters.ContainsKey('SamplingAlgorithmType')) {
            $Object.SamplingAlgorithmType = $SamplingAlgorithmType
        }
        if ($PSBoundParameters.ContainsKey('SearchSpace')) {
            $Object.SearchSpace = $SearchSpace
        }
        if ($PSBoundParameters.ContainsKey('TrialCodeId')) {
            $Object.TrialCodeId = $TrialCodeId
        }
        if ($PSBoundParameters.ContainsKey('TrialCommand')) {
            $Object.TrialCommand = $TrialCommand
        }
        if ($PSBoundParameters.ContainsKey('TrialEnvironmentId')) {
            $Object.TrialEnvironmentId = $TrialEnvironmentId
        }
        if ($PSBoundParameters.ContainsKey('TrialEnvironmentVariable')) {
            $Object.TrialEnvironmentVariable = $TrialEnvironmentVariable
        }
        if ($PSBoundParameters.ContainsKey('ComputeId')) {
            $Object.ComputeId = $ComputeId
        }
        if ($PSBoundParameters.ContainsKey('DisplayName')) {
            $Object.DisplayName = $DisplayName
        }
        if ($PSBoundParameters.ContainsKey('ExperimentName')) {
            $Object.ExperimentName = $ExperimentName
        }
        if ($PSBoundParameters.ContainsKey('IdentityType')) {
            $Object.IdentityType = $IdentityType
        }
        if ($PSBoundParameters.ContainsKey('IsArchived')) {
            $Object.IsArchived = $IsArchived
        }
        # if ($PSBoundParameters.ContainsKey('Service')) {
        #     $Object.Service = $Service
        # }
        if ($PSBoundParameters.ContainsKey('ServiceEndpoint')) {
            $Service.Endpoint = $ServiceEndpoint
        }
        if ($PSBoundParameters.ContainsKey('ServicePort')) {
            $Service.Port = $ServicePort
        }
        if ($PSBoundParameters.ContainsKey('ServiceProperty')) {
            $Service.Property = $ServiceProperty
        }
        if ($PSBoundParameters.ContainsKey('ServiceType')) {
            $Service.Type = $ServiceType
        }

        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('Property')) {
            $Object.Property = $Property
        }
        if ($PSBoundParameters.ContainsKey('Tag')) {
            $Object.Tag = $Tag
        }
        $Object.Service = $Service
        return $Object
    }
}

