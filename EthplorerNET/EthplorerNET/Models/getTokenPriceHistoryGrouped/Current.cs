using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenPriceHistoryGrouped
{
    public class Current
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; protected set; }
    }
}
