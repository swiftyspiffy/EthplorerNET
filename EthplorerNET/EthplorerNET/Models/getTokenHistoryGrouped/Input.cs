using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTokenHistoryGrouped
{
    public class Input
    {
        public string Address { get; set; } = null;
        public int Period { get; set; } = 30;
    }
}
