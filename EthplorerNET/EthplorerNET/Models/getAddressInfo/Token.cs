using EthplorerNET.Models.Shared.TokenInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressInfo
{
    public class Token
    {
        /// <summary>Token info</summary>
        [JsonProperty(PropertyName = "tokenInfo")]
        public TokenInfo TokenInfo { get; protected set; }
        /// <summary>Amount held</summary>
        [JsonProperty(PropertyName = "balance")]
        public double Balance { get; protected set; }
        /// <summary>Total tokens coming in</summary>
        [JsonProperty(PropertyName = "totalIn")]
        public double TotalIn { get; protected set; }
        /// <summary>Total tokens going out</summary>
        [JsonProperty(PropertyName = "totalOut")]
        public double TotalOut { get; protected set; }
    }
}
