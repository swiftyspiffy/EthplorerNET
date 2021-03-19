using System;
using System.Collections.Generic;
using System.Text;

namespace EthplorerNET.Models.getTxInfo
{
    public class Input
    {
        /// <summary>Transaction hash to get information on</summary>
        public string TransactionHash { get; set; } = null;
    }
}
