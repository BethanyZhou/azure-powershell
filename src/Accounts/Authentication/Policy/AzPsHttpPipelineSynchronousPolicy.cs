﻿using Azure.Core;
using Azure.Core.Pipeline;

using Microsoft.WindowsAzure.Commands.Utilities.Common;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Microsoft.Azure.Commands.Common.Authentication.Policy
{
    internal class AzPsHttpPipelineSynchronousPolicy: HttpPipelineSynchronousPolicy
    {
        private IList<ProductInfoHeaderValue> userAgents;

        public AzPsHttpPipelineSynchronousPolicy() 
        {
            userAgents = new List<ProductInfoHeaderValue>();
        }

        public void AddUserAgent(ProductInfoHeaderValue userAgent)
        {
            userAgents.Add(userAgent);
        }

        public override void OnSendingRequest(HttpMessage message)
        {
            userAgents?.ForEach((agent)=> {
                message.Request.Headers.Add("Custom-Header", agent.ToString());
            });
        }
    }
}
