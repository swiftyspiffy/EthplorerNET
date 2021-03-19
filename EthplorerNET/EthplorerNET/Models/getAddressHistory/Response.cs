using EthplorerNET.Models.Shared.Operation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressHistory
{
    public class Responsea
    {
        /// <summary>address history in operations</summary>
        [JsonProperty(PropertyName = "operations")]
        public Operation[] Operations { get; protected set; }
    }
}
