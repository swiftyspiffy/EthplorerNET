using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressInfo
{
    public class Input
    {
        /// <summary>Address to lookup</summary>
        public string Address { get; set; }

        /// <summary>show balances for specified token address only</summary>
        public string Token { get; set; } = "";

        /// <summary>request total incoming and outgoing ETH value</summary>
        public bool ShowETHTotals { get; set; } = false;
    }
}
