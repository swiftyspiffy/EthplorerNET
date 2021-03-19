using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressInfo
{
    public class EthInfo
    {
        /// <summary>ETH balance</summary>
        [JsonProperty(PropertyName = "balance")]
        public double Balance { get; protected set; }
        /// <summary>Total incoming ETH value (showETHTotals parameter should be set to get this value)</summary>
        [JsonProperty(PropertyName = "totalIn")]
        public double TotalIn { get; protected set; }
        /// <summary>Total outgoing ETH value (showETHTotals parameter should be set to get this value)</summary>
        [JsonProperty(PropertyName = "totalOut")]
        public double TotalOut { get; protected set; }
        /// <summary>Total transaction count</summary>
        [JsonProperty(PropertyName = "countTxs")]
        public long CountTxs { get; protected set; }
    }
}
