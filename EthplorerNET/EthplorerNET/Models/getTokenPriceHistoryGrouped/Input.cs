using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenPriceHistoryGrouped
{
    public class Input
    {
        public string Address { get; protected set; }
        public int Period { get; protected set; } = 365;
    }
}
