using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTopTokenHolders
{
    public class TopTokenHolder
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "balance")]
        public double Balance { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "share")]
        public double Share { get; protected set; }
    }
}
