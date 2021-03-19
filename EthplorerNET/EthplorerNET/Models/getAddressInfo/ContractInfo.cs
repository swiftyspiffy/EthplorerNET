using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressInfo
{
    public class ContractInfo
    {
        /// <summary>contract creator address,</summary>
        [JsonProperty(PropertyName = "creatorAddress")]
        public string CreatorAddress { get; protected set; }
        /// <summary>contract creation transaction hash</summary>
        [JsonProperty(PropertyName = "transactionHash")]
        public string TransactionHash { get; protected set; }
        /// <summary>contract creation timestamp</summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; protected set; }
    }
}
