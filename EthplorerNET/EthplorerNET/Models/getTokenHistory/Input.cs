using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenHistory
{
    public class Input
    {
        public string Address { get; set; } = null;
        public string Type { get; set; } = "transfer";
        public int Limit { get; set; } = 10;
        public long? Timestamp { get; set; } = null;
    }
}
