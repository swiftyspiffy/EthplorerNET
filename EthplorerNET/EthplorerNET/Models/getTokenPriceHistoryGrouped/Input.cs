using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenPriceHistoryGrouped
{
    public class Input
    {
        public string Address { get; set; }
        public int Period { get; set; } = 365;
    }
}
