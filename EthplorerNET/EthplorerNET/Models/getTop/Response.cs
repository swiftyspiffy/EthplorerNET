using EthplorerNET.Models.Shared.Totals;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTop
{
    public class Response
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "tokens")]
        public Token[] Tokens { get; protected set; }

        /// <summary></summary>
        [JsonProperty(PropertyName = "totals")]
        public Totals Totals { get; protected set; }
    }
}
