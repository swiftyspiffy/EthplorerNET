using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.Shared.Operation
{
    public class Operation
    {
        /// <summary>ETH balance</summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; protected set; }
        /// <summary>ETH balance</summary>
        [JsonProperty(PropertyName = "transactionHash")]
        public string TransactionHash { get; protected set; }
        /// <summary>ETH balance</summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; protected set; }
        /// <summary>ETH balance</summary>
        [JsonProperty(PropertyName = "intValue")]
        public int IntValue { get; protected set; }
        /// <summary>ETH balance</summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; protected set; }
        /// <summary>ETH balance</summary>
        [JsonProperty(PropertyName = "priority")]
        public long Priority { get; protected set; }
        /// <summary>source address (if two addresses involved)</summary>
        [JsonProperty(PropertyName = "from")]
        public string From { get; protected set; }
        /// <summary>destination address (if two addresses involved)</summary>
        [JsonProperty(PropertyName = "to")]
        public string To { get; protected set; }
        /// <summary>involved addresses</summary>
        [JsonProperty(PropertyName = "addresses")]
        public string[] Addresses { get; protected set; }
        /// <summary>whether operation is for eth or not</summary>
        [JsonProperty(PropertyName = "isEth")]
        public bool IsEth { get; protected set; }
        /// <summary>value of operation in USD currency</summary>
        [JsonProperty(PropertyName = "usdPrice")]
        public double UsdPrice { get; protected set; }
        /// <summary>information on token</summary>
        [JsonProperty(PropertyName = "tokenInfo")]
        public TokenInfo.TokenInfo TokenInfo { get; protected set; }
    }
}
