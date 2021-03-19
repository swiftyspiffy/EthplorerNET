using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTopTokenHolders
{
    public class Response
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "holders")]
        public Holder[] Holders { get; protected set; }
    }
}
