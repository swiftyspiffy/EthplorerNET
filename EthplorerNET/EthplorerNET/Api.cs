using System;
using System.Threading.Tasks;

namespace EthplorerNET
{
    public class Api
    {
        private string ApiKey;

        public Api(string apiKey = "freekey")
        {
            ApiKey = apiKey;
        }

        public async Task<Models.getLastBlock.Response> GetLastBlock(string accessKey = "")
        {

        }

        public async Task<Models.Shared.TokenInfo.TokenInfo> GetTokenInfo(Models.getTokenInfo.Input input, string accessKey = "")
        {

        }

        public async Task<Models.getAddressInfo.Response> GetAddressInfo(Models.getAddressInfo.Input input, string accessKey = "")
        {

        }

        public async Task<Models.getTxInfo.Response> GetTxInfo(Models.getTxInfo.Input input, string accessKey = "")
        {

        }

        public async Task<Models.getTokenHistory.Response> GetTokenHistory(Models.getTokenHistory.Input input, string accessKey = "")
        {

        }
    }
}
