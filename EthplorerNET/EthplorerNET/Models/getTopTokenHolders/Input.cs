using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTopTokenHolders
{
    public class Input
    {
        public string Address { get; set; } = null;
        public int Limit { get; set; } = 10;
    }
}
