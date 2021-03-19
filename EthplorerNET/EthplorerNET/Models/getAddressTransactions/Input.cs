using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressTransactions
{
    public class Input
    {
        public string Address { get; set; } = null;
        public int Limit { get; set; } = 10;
        public long? Timestamp { get; set; } = null;
        public bool ShowZeroValues { get; set; }
    }
}
