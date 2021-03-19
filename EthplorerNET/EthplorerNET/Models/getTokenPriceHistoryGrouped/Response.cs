using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenPriceHistoryGrouped
{
    public class Response
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "history")]
        public History History { get; protected set; }
    }
}
