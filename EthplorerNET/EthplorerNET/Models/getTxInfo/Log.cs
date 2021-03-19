using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTxInfo
{
    public class Log
    {
        /// <summary>log record address</summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; protected set; }
        /// <summary>log record topics</summary>
        [JsonProperty(PropertyName = "topics")]
        public string[] Topics { get; protected set; }
        /// <summary>log record data</summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; protected set; }
    }
}
