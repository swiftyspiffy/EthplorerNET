
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressTransactions
{
    public class Transaction
    {
        /// <summary>unix timestamp of transaction</summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; protected set; }
        /// <summary>source of transaction</summary>
        [JsonProperty(PropertyName = "from")]
        public string From { get; protected set; }
        /// <summary>destination of transaction</summary>
        [JsonProperty(PropertyName = "to")]
        public string To { get; protected set; }
        /// <summary>hash of transaction</summary>
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; protected set; }
        /// <summary>input value</summary>
        [JsonProperty(PropertyName = "value")]
        public double Value { get; protected set; }
        /// <summary>input data</summary>
        [JsonProperty(PropertyName = "input")]
        public string Input { get; protected set; }
        /// <summary>true if transaction was completed, false if failed</summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; protected set; }
    }
}
