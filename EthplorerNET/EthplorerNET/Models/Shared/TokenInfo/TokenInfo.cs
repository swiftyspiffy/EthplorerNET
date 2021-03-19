
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.Shared.TokenInfo
{
    public class TokenInfo
    {
        /// <summary>token address</summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; protected set; }
        /// <summary>total token supply</summary>
        [JsonProperty(PropertyName = "totalSupply")]
        public string TotalSupply { get; protected set; }
        /// <summary>token name</summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
        /// <summary>token symbol</summary>
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; protected set; }
        /// <summary>number of significant digits</summary>
        [JsonProperty(PropertyName = "decimals")]
        public string Decimals { get; protected set; }
        /// <summary>token price (false, if not available)</summary>
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; protected set; }
        /// <summary>token owner address</summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; protected set; }
        /// <summary>total count of token operations</summary>
        [JsonProperty(PropertyName = "countOps")]
        public long CountOps { get; protected set; }
        /// <summary>total amount of incoming tokens</summary>
        [JsonProperty(PropertyName = "totalIn")]
        public long TotalIn { get; protected set; }
        /// <summary>total amount of outgoing tokens</summary>
        [JsonProperty(PropertyName = "totalOut")]
        public long TotalOut { get; protected set; }
        /// <summary>total number of token operations</summary>
        [JsonProperty(PropertyName = "transfersCount")]
        public long TransfersCount { get; protected set; }
        /// <summary>total number of ethereum operations, optional</summary>
        [JsonProperty(PropertyName = "ethTransfersCount")]
        public long EthTransferCount { get; protected set; }
        /// <summary>total numnber of token holders</summary>
        [JsonProperty(PropertyName = "holdersCount")]
        public long HoldersCount { get; protected set; }
        /// <summary>total count of token issuances</summary>
        [JsonProperty(PropertyName = "issuancesCount")]
        public long IssuancesCount { get; protected set; }
        /// <summary>token image url, optional</summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; protected set; }
        /// <summary>token description, optional</summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; protected set; }
        /// <summary>token website url, optional</summary>
        [JsonProperty(PropertyName = "website")]
        public string Website { get; protected set; }
        /// <summary>token facebook name, optional</summary>
        [JsonProperty(PropertyName = "facebook")]
        public string Facebook { get; protected set; }
        /// <summary>token telegram url, optional</summary>
        [JsonProperty(PropertyName = "telegram")]
        public string Telegram { get; protected set; }
        /// <summary>token twitter alias, optional</summary>
        [JsonProperty(PropertyName = "twitter")]
        public string Twitter { get; protected set; }
        /// <summary>token subreddit alias, optional</summary>
        [JsonProperty(PropertyName = "reddit")]
        public string Reddit { get; protected set; }
        /// <summary>token coingecko alias, optional</summary>
        [JsonProperty(PropertyName = "coingecko")]
        public string Coingecko { get; protected set; }
        /// <summary>last update timestamp</summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public long LastUpdated { get; protected set; }

    }
}
