using EthplorerNET.Models.Shared.TokenInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTop
{
    public class Token
    {
        /// <summary></summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume")]
        public double Volume { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap")]
        public double Cap { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "availableSupply")]
        public double AvailableSupply { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "price")]
        public Price Price { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume-1d-current")]
        public double Volume1dCurrent { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume-1d-previous")]
        public double Volume1dPrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-1d-current")]
        public double Cap1dCurrent { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-1d-previous")]
        public double Cap1dPrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-1d-previous-ts")]
        public long Cap1dPreviousTs { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume-7d-current")]
        public double Volume7dCurrent { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume-7d-previous")]
        public double Volume7dPrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-7d-current")]
        public double Cap7dCurrent { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-7d-previous")]
        public double Cap7dPrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-7d-previous-ts")]
        public long Cap7dPreviousTs { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume-30d-current")]
        public double Volume30dCurrent { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "volume-30d-previous")]
        public double Volume30dPrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-30d-current")]
        public double Cap30dCurrent { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-30d-previous")]
        public double Cap30dPrevious { get; protected set; }
        /// <summary></summary>
        [JsonProperty(PropertyName = "cap-30d-previous-ts")]
        public long Cap30dPreviousTs { get; protected set; }
    }
}
