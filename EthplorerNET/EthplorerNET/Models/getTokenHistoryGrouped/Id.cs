
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenHistoryGrouped
{
    public class Id
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "year")]
        public int Year { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "month")]
        public int Month { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "day")]
        public int Day { get; protected set; }
    }
}
