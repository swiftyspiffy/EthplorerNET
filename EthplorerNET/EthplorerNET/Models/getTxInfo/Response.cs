
using EthplorerNET.Models.Shared.Operation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTxInfo
{
    public class Response
    {
        /// <summary>transaction hash</summary>
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; protected set; }
        /// <summary>transaction block time</summary>
        [JsonProperty(PropertyName = "transaction")]
        public long Timestamp { get; protected set; }
        /// <summary>transaction block number</summary>
        [JsonProperty(PropertyName = "blockNumber")]
        public long BlockNumber { get; protected set; }
        /// <summary>number of confirmations</summary>
        [JsonProperty(PropertyName = "confirmations")]
        public long Confirmations { get; protected set; }
        /// <summary>true if there were no errors during tx execution</summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; protected set; }
        /// <summary>source address</summary>
        [JsonProperty(PropertyName = "from")]
        public string From { get; protected set; }
        /// <summary>destination address</summary>
        [JsonProperty(PropertyName = "to")]
        public string To { get; protected set; }
        /// <summary>ETH send value</summary>
        [JsonProperty(PropertyName = "value")]
        public double Value { get; protected set; }
        /// <summary>transaction input data (hex)</summary>
        [JsonProperty(PropertyName = "input")]
        public string Input { get; protected set; }
        /// <summary>gas limit set to this transaction</summary>
        [JsonProperty(PropertyName = "gasLimit")]
        public double GasLimit { get; protected set; }
        /// <summary>gas used for this transaction</summary>
        [JsonProperty(PropertyName = "gasUsed")]
        public double GasUsed { get; protected set; }
        /// <summary>address of created contract (if available)</summary>
        [JsonProperty(PropertyName = "creates")]
        public string Creates { get; protected set; }
        /// <summary>event logs</summary>
        [JsonProperty(PropertyName = "creates")]
        public Log[] Logs { get; protected set; }
        /// <summary>event operations</summary>
        [JsonProperty(PropertyName = "operations")]
        public Operation[] Operations { get; protected set; }
    }
}
