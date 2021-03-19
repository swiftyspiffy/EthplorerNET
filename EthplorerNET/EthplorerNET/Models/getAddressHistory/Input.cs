using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getAddressHistory
{
    public class Input
    {
        public string Address { get; set; } = null;
        public string Token { get; set; } = null;
        public string Type { get; set; } = null;
        public int Limit { get; set; } = 10;
        public long? Timestamp { get; set; } = null;
    }
}
