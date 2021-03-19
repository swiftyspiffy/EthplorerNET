using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.Shared.TokenInfo
{
    public class Price
    {
        /// <summary>current rate</summary>
        [JsonProperty(PropertyName = "rate")]
        public double Rate { get; protected set; }
        /// <summary>token price currency (USD)</summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; protected set; }
        /// <summary>24 hours rate difference (in percent)</summary>
        [JsonProperty(PropertyName = "diff")]
        public double Diff { get; protected set; }
        /// <summary>7 days rate difference (in percent)</summary>
        [JsonProperty(PropertyName = "diff7d")]
        public double Diff7d { get; protected set; }
        /// <summary>30 days rate difference (in percent)</summary>
        [JsonProperty(PropertyName = "diff30d")]
        public double Diff30d { get; protected set; }
        /// <summary>market cap (USD)</summary>
        [JsonProperty(PropertyName = "marketCapUsd")]
        public double MarketCapUsd { get; protected set; }
        /// <summary>available supply</summary>
        [JsonProperty(PropertyName = "availableSupply")]
        public double AvailableSupply { get; protected set; }
        /// <summary>24 hours volume</summary>
        [JsonProperty(PropertyName = "volume24h")]
        public double Volume24h { get; protected set; }
        /// <summary>last rate update timestamp</summary>
        [JsonProperty(PropertyName = "ts")]
        public long Ts { get; protected set; }
        /// <summary>volume diff over 1 day</summary>
        [JsonProperty(PropertyName = "volDiff1")]
        public double VolDiff1 { get; protected set; }
        /// <summary>volume diff over 7 days</summary>
        [JsonProperty(PropertyName = "volDiff7")]
        public double VolDiff7 { get; protected set; }
        /// <summary>volume diff over 30 days</summary>
        [JsonProperty(PropertyName = "volDiff30")]
        public double VolDiff30 { get; protected set; }
        /// <summary>flag set if only price data is returned</summary>
        [JsonProperty(PropertyName = "onlyPrice")]
        public int OnlyPrice { get; protected set; }
        /// <summary>Assigned token tags</summary>
        [JsonProperty(PropertyName = "publicTags")]
        public string[] PublicTags { get; protected set; }
    }
}
