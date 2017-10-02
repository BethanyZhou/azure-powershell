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

using Microsoft.Azure.Commands.Resources.Test.ScenarioTests;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Profile.Test
{
    public class DefaultCmdletTests : RMTestBase
    {
        private XunitTracingInterceptor xunitLogger;

        public DefaultCmdletTests(ITestOutputHelper output)
        {
            xunitLogger = new XunitTracingInterceptor(output);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void SetAzureRmDefaultResourceGroupValid()
        {
            ProfileController.NewInstance.RunPsTest(xunitLogger, "72f988bf-86f1-41af-91ab-2d7cd011db47", "Test-SetAzureRmDefaultResourceGroupValid");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void SetAzureRmDefaultResourceGroupNotValid()
        {
            ProfileController.NewInstance.RunPsTest(xunitLogger, "72f988bf-86f1-41af-91ab-2d7cd011db47", "Test-SetAzureRmDefaultResourceGroupNotValid");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void GetAzureRmDefaultNoDefault()
        {
            ProfileController.NewInstance.RunPsTest(xunitLogger, "72f988bf-86f1-41af-91ab-2d7cd011db47", "Test-GetAzureRmDefaultNoDefault");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void GetAzureRmDefaultWithDefault()
        {
            ProfileController.NewInstance.RunPsTest(xunitLogger, "72f988bf-86f1-41af-91ab-2d7cd011db47", "Test-GetAzureRmDefaultWithDefault");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void ClearAzureRmDefaultNoDefault()
        {
            ProfileController.NewInstance.RunPsTest(xunitLogger, "72f988bf-86f1-41af-91ab-2d7cd011db47", "Test-ClearAzureRmDefaultNoDefault");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void ClearAzureRmDefaultWithDefault()
        {
            ProfileController.NewInstance.RunPsTest(xunitLogger, "72f988bf-86f1-41af-91ab-2d7cd011db47", "Test-ClearAzureRmDefaultWithDefault");
        }
    }
}
