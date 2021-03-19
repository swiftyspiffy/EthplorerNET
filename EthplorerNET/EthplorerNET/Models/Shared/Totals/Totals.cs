using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.Shared.Totals
{
    public class Totals
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "tokens")]
        public long Tokens { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "tokensWithPrice")]
        public long TokensWithPrice { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap")]
        public double Cap { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "capPrevious")]
        public double CapPrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume24h")]
        public double Volume24h { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volumePrevious")]
        public double VolumePrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "ts")]
        public long Ts { get; protected set; }
    }
}
