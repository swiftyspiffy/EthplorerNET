
using EthplorerNET.Models.Shared.Operation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenHistory
{
    public class Response
    {
        /// <summary>token history in operations</summary>
        [JsonProperty(PropertyName = "operations")]
        public Operation[] Operations { get; protected set; }
    }
}
