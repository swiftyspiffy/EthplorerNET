using EthplorerNET.Models.Shared.CountTxs;
using EthplorerNET.Models.Shared.Totals;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenHistoryGrouped
{
    public class Response
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "countTxs")]
        public CountTx[] CountTxs { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "totals")]
        public Totals Totals { get; protected set; }
    }
}
