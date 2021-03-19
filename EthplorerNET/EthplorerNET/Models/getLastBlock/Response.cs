
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getLastBlock
{
    public class Response
    {
        /// <summary>last scanned block number</summary>
        [JsonProperty(PropertyName = "lastBlock")]
        public long LastBlock { get; protected set; }
    }
}
