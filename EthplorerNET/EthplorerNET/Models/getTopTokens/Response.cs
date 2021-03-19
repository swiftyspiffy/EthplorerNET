using EthplorerNET.Models.Shared.TokenInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTopTokens
{
    public class Response
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "tokens")]
        public TokenInfo[] Tokens { get; protected set; }
    }
}
