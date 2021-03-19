using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTopTokenHolders
{
    public class Input
    {
        public string Address { get; protected set; } = null;
        public int Limit { get; protected set; } = 10;
    }
}
