using EthplorerNET.Models.Shared.CountTxs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenPriceHistoryGrouped
{
    public class History
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "current")]
        public Current Current { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "countTxs")]
        public CountTx[] CountTxs { get; protected set; }
    }
}
