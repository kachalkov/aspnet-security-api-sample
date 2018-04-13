/* 
*  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. 
*  See LICENSE in the source repository root for complete license information. 
*/

using Microsoft.Graph;

namespace MicrosoftGraph_Security_API_Sample.Models
{
    public class AlertModel
    {
        public string Id { get; set; }

        public string Metadata { get; set; }

        public GraphUserModel User { get; set; }

        public AlertDeviceModel Device { get; set; }

        public string Query { get; set; }
    }
}