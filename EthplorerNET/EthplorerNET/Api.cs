using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace EthplorerNET
{
    public class Api
    {
        private const string BASE_API = "https://api.ethplorer.io/";

        private string ApiKey;

        public Api(string apiKey = "freekey")
        {
            ApiKey = apiKey;
        }

        public async Task<Models.getLastBlock.Response> GetLastBlock(string accessKey = "")
        {
            return await GetGeneric<Models.getLastBlock.Response>("getLastBlock", new List<KeyValuePair<string, string>> { }, accessKey);
        }

        public async Task<Models.Shared.TokenInfo.TokenInfo> GetTokenInfo(Models.getTokenInfo.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.Address))
                throw new Exception("Address cannot be null or empty");

            return await GetGeneric<Models.Shared.TokenInfo.TokenInfo>($"getTokenInfo/{input.Address}", accessKey: accessKey);
        }

        public async Task<Models.getAddressInfo.Response> GetAddressInfo(Models.getAddressInfo.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.Address))
                throw new Exception("Address cannot be null or empty");

            var args = new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("showETHTotals", input.ShowETHTotals.ToString().ToLower()) };
            if (input.Token != null)
                args.Add(new KeyValuePair<string, string>("token", input.Token));

            return await GetGeneric<Models.getAddressInfo.Response>($"getAddressInfo/{input.Address}", args, accessKey);
        }

        public async Task<Models.getTxInfo.Response> GetTxInfo(Models.getTxInfo.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.TransactionHash))
                throw new Exception("Transaction hash cannot be null or empty");

            return await GetGeneric<Models.getTxInfo.Response>($"getTxInfo/{input.TransactionHash}", accessKey: accessKey);
        }

        public async Task<Models.getTokenHistory.Response> GetTokenHistory(Models.getTokenHistory.Input input, string accessKey = "")
        {
            var args = new List<KeyValuePair<string, string>> { 
                new KeyValuePair<string, string>("type", input.Type.ToLower()),
                new KeyValuePair<string, string>("limit", input.Limit.ToString())
            };
            if (input.Timestamp != null)
                args.Add(new KeyValuePair<string, string>("timestamp", input.Timestamp.Value.ToString()));

            return await GetGeneric<Models.getTokenHistory.Response>($"getTokenHistory{(!String.IsNullOrEmpty(input.Address) ? $"/{input.Address}" : "")}", args, accessKey);
        }

        public async Task<Models.getAddressHistory.Response> GetAddressHistory(Models.getAddressHistory.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.Address))
                throw new Exception("Address cannot be null or empty");

            var args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("limit", input.Limit.ToString())
            };
            if (input.Token != null)
                args.Add(new KeyValuePair<string, string>("token", input.Token));
            if (input.Type != null)
                args.Add(new KeyValuePair<string, string>("type", input.Type));
            if (input.Timestamp != null)
                args.Add(new KeyValuePair<string, string>("timestamp", input.Timestamp.Value.ToString()));

            return await GetGeneric<Models.getAddressHistory.Response>($"getAddressHistory/{input.Address}", args, accessKey);
        }

        public async Task<Models.getAddressTransactions.Transaction[]> GetAddressTransactions(Models.getAddressTransactions.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.Address))
                throw new Exception("Address cannot be null or empty");

            var args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("limit", input.Limit.ToString()),
                new KeyValuePair<string, string>("showZeroValues", input.ShowZeroValues ? "1" : "0")
            };
            if (input.Timestamp != null)
                args.Add(new KeyValuePair<string, string>("timestamp", input.Timestamp.Value.ToString()));

            return await GetGeneric<Models.getAddressTransactions.Transaction[]>($"getAddressTransactions/{input.Address}", args, accessKey);
        }

        public async Task<Models.getTop.Response> GetTop(Models.getTop.Input input, string accessKey = "")
        {
            var args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("criteria", input.Criteria.ToString().ToLower()),
                new KeyValuePair<string, string>("limit", input.Limit.ToString())
            };

            return await GetGeneric<Models.getTop.Response>("getTop", args, accessKey);
        }

        public async Task<Models.getTopTokens.Response> GetTopTokens(string accessKey = "")
        {
            return await GetGeneric<Models.getTopTokens.Response>("getTopTokens", accessKey: accessKey);
        }

        public async Task<Models.getTopTokenHolders.Response> GetTopTokenHolders(Models.getTopTokenHolders.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.Address))
                throw new Exception("Address cannot be null or empty");

            var args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("limit", input.Limit.ToString())
            };

            return await GetGeneric<Models.getTopTokenHolders.Response>($"getTopTokenHolders/{input.Address}", args, accessKey);
        }

        public async Task<Models.getTokenHistoryGrouped.Response> GetTokenHistoryGrouped(Models.getTokenHistoryGrouped.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.Address))
                throw new Exception("Address cannot be null or empty");

            var args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("period", input.Period.ToString())
            };

            return await GetGeneric<Models.getTokenHistoryGrouped.Response>($"getTokenHistoryGrouped/{input.Address}", args, accessKey);
        }

        public async Task<Models.getTokenPriceHistoryGrouped.Response> GetTokenPriceHistoryGrouped(Models.getTokenPriceHistoryGrouped.Input input, string accessKey = "")
        {
            if (String.IsNullOrEmpty(input.Address))
                throw new Exception("Address cannot be null or empty");

            var args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("period", input.Period.ToString())
            };

            return await GetGeneric<Models.getTokenPriceHistoryGrouped.Response>($"getTokenPriceHistoryGrouped/{input.Address}", args, accessKey);
        }

        private async Task<T> GetGeneric<T>(string resource, List<KeyValuePair<string, string>> args = null, string accessKey = "")
        {
            var url = $"{BASE_API}/{resource}";
            var key = ApiKey;
            if (!String.IsNullOrEmpty(accessKey))
                key = accessKey;
            if (String.IsNullOrEmpty(key))
                throw new Exception("Api key in instance and arg cannot be empty or null");

            if(args != null && args.Count > 0)
            {
                args = new List<KeyValuePair<string, string>> { };
            }
            args.Add(new KeyValuePair<string, string>("apiKey", key));
            for (var i = 0; i < args.Count; i++)
            {
                if (i == 0)
                    url += $"?{args[0].Key}={args[1].Value}";
                else
                    url += $"&{args[0].Key}={args[1].Value}";
            }

            var deserializeSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<T>(result, deserializeSettings);
            }
        }
    }
}
