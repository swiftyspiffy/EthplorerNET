using EthplorerNET.Models.Shared.TokenInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressInfo
{
    public class Response
    {
        /// <summary>address</summary>
        [JsonProperty(PropertyName = "balance")]
        public string Address { get; protected set; }
        /// <summary>ETH specific information</summary>
        [JsonProperty(PropertyName = "ETH")]
        public EthInfo ETH { get; protected set; }
        /// <summary>exists if specified address is a contract</summary>
        [JsonProperty(PropertyName = "contractInfo")]
        public ContractInfo ContractInfo { get; protected set; }
        /// <summary>exists if specified address is a token contract address</summary>
        [JsonProperty(PropertyName = "tokenInfo")]
        public TokenInfo TokenInfo { get; protected set; }
        /// <summary>exists if specified address has any token balances</summary>
        [JsonProperty(PropertyName = "tokens")]
        public Token[] Tokens { get; protected set; }
    }
}
