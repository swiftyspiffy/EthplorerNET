using EthplorerNET.Models.getTokenHistoryGrouped;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.Shared.CountTxs
{
    public class CountTx
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "ts")]
        public long Ts { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cnt")]
        public long Cnt { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "_id")]
        public Id Id { get; protected set; }
    }
}
