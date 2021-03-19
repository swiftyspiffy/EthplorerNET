using EthplorerNET.Models.getAddressInfo;
using EthplorerNET.Models.Shared.TokenInfo;
using System;

namespace EthplorerNET.Test
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("This application is used to test the functionality exposed in EthplorerNET.");

            var api = new EthplorerNET.Api(); // uses freekey apikey, can also initialize with custom api key: new ExplorerNET.Api("my-api-key");
            
            Console.WriteLine($"GetLastBlock:");
            var getLastBlockResponse = api.GetLastBlock().GetAwaiter().GetResult();
            Console.WriteLine($" - Last block: {getLastBlockResponse.LastBlock}");
            Console.WriteLine();

            Console.WriteLine($"GetTokenInfo:");
            var getTokenInfoResponse = api.GetTokenInfo(new Models.getTokenInfo.Input
            {
                Address = "0xf3db5fa2c66b7af3eb0c0b782510816cbe4813b8"
            }).GetAwaiter().GetResult();
            printTokenInfo(getTokenInfoResponse);
            Console.WriteLine();

            Console.WriteLine($"GetAddressInfo:");
            var getAddressInfoResponse = api.GetAddressInfo(new Models.getAddressInfo.Input
            {
                Address = "0xff71cb760666ab06aa73f34995b42dd4b85ea07b"
            }).GetAwaiter().GetResult();
            printGetAddressInfoResponse(getAddressInfoResponse);
            Console.WriteLine();

            Console.WriteLine($"GetTxInfo:");
            var getTxInfoResponse = api.GetTxInfo(new Models.getTxInfo.Input
            {
                TransactionHash = "0x6aa670c983425eba23314459c48ae89b3b8d0e1089397c56400ce2da5ece9d26"
            }).GetAwaiter().GetResult();
            printTxInfo(getTxInfoResponse);
            Console.WriteLine();


            Console.WriteLine($"GetTokenHistory:");
            var getTokenHistoryResponse = api.GetTokenHistory(new Models.getTokenHistory.Input
            {
                Address = "0xff71cb760666ab06aa73f34995b42dd4b85ea07b",
                Type = "transfer",
                Limit = 5
            }).GetAwaiter().GetResult();
            printGetTokenHistory(getTokenHistoryResponse);
            Console.WriteLine();

            Console.WriteLine($"GetAddressHistory:");
            var getAddressHistoryResponse = api.GetAddressHistory(new Models.getAddressHistory.Input
            {
                Address = "0x1f5006dff7e123d550abc8a4c46792518401fcaf",
                Type = "transfer"
            }).GetAwaiter().GetResult();
            printGetAddressHistory(getAddressHistoryResponse);
            Console.WriteLine();

            Console.WriteLine($"GetAddressTransactions:");
            var getAddressTransactionsResponse = api.GetAddressTransactions(new Models.getAddressTransactions.Input
            {
                Address = "0xb297cacf0f91c86dd9d2fb47c6d12783121ab780"
            }).GetAwaiter().GetResult();
            printGetAddressTransactions(getAddressTransactionsResponse);
            Console.WriteLine();

            Console.WriteLine($"GetTop:");
            var getTopResponse = api.GetTop(new Models.getTop.Input
            {
                Criteria = Models.getTop.CriteriaEnum.CAP
            }).GetAwaiter().GetResult();
            printGetTop(getTopResponse);
            Console.WriteLine();

            Console.WriteLine($"GetTopTokens:");
            var getTopTokensResponse = api.GetTopTokens().GetAwaiter().GetResult();
            printGetTopTokens(getTopTokensResponse);
            Console.WriteLine();

            Console.WriteLine($"GetTopTokenHolders:");
            var getTopTokenHoldersResponse = api.GetTopTokenHolders(new Models.getTopTokenHolders.Input
            {
                Address = "0xf3Db5Fa2C66B7aF3Eb0C0b782510816cbe4813b8",
                Limit = 100
            }).GetAwaiter().GetResult();
            printTopTokenHolders(getTopTokenHoldersResponse);
            Console.WriteLine();

            Console.WriteLine($"GetTokenHistoryGrouped:");
            var getTokenHistoryGroupedResponse = api.GetTokenHistoryGrouped(new Models.getTokenHistoryGrouped.Input
            {
                Address = "0xf3db5fa2c66b7af3eb0c0b782510816cbe4813b8"
            }).GetAwaiter().GetResult();
            printGetTokenHistoryGroupedResponse(getTokenHistoryGroupedResponse);
            Console.WriteLine();

            Console.WriteLine($"GetTokenPriceHistoryGrouped:");
            var getTokenPriceHistoryGroupedResponse = api.GetTokenPriceHistoryGrouped(new Models.getTokenPriceHistoryGrouped.Input
            {
                Address = "0x48c80f1f4d53d5951e5d5438b54cba84f29f32a5"
            }).GetAwaiter().GetResult();
            printGetTokenPriceHistoryGroupedResponse(getTokenPriceHistoryGroupedResponse);
            Console.WriteLine();

            Console.WriteLine($"Completed!");
            Console.ReadLine();
        }

        private static void printGetTokenPriceHistoryGroupedResponse(Models.getTokenPriceHistoryGrouped.Response response)
        {
            Console.WriteLine($" - CountTxs:");
            foreach (var countTx in response.History.CountTxs)
                printCountTx(countTx);
            Console.WriteLine($" - Current Symbol: {response.History.Current.Symbol}");
        }

        private static void printGetTokenHistoryGroupedResponse(Models.getTokenHistoryGrouped.Response response)
        {
            Console.WriteLine(" - CountTxs:");
            foreach (var countTx in response.CountTxs)
                printCountTx(countTx);
            Console.WriteLine(" - Totals:");
            printTotals(response.Totals);
        }

        private static void printCountTx(Models.Shared.CountTxs.CountTx countTx)
        {
            Console.WriteLine($"   - Cnt: {countTx.Cnt}");
            Console.WriteLine($"   - Id: {countTx.Id}");
            Console.WriteLine($"   - Ts: {countTx.Ts}");
        }

        private static void printTopTokenHolders(Models.getTopTokenHolders.Response response)
        {
            Console.WriteLine($" - Holders:");
            foreach(var holder in response.Holders)
            {
                Console.WriteLine($"   - Address: {holder.Address}");
                Console.WriteLine($"   - Balance: {holder.Balance}");
                Console.WriteLine($"   - Share: {holder.Share}");
            }
        }

        private static void printGetTopTokens(Models.getTopTokens.Response response)
        {
            Console.WriteLine($" - Tokens: ");
            foreach(var token in response.Tokens)
                printTokenInfo(token);
        }

        private static void printGetTop(Models.getTop.Response response)
        {
            Console.WriteLine($" - Tokens:");
            foreach(var token in response.Tokens)
            {
                Console.WriteLine($"   - Address: {token.Address}");
                Console.WriteLine($"   - AvailableSupply: {token.AvailableSupply}");
                Console.WriteLine($"   - Cap: {token.Cap}");
                Console.WriteLine($"   - Cap1dCurrent: {token.Cap1dCurrent}");
                Console.WriteLine($"   - Cap1dPrevious: {token.Cap1dPrevious}");
                Console.WriteLine($"   - Cap1dPreviousTs: {token.Cap1dPreviousTs}");
                Console.WriteLine($"   - Cap30dCurrent: {token.Cap30dCurrent}");
                Console.WriteLine($"   - Cap30dPrevious: {token.Cap30dPrevious}");
                Console.WriteLine($"   - Cap30dPreviousTs: {token.Cap30dPreviousTs}");
                Console.WriteLine($"   - Cap7dCurrent: {token.Cap7dCurrent}");
                Console.WriteLine($"   - Cap7dPrevious: {token.Cap7dPrevious}");
                Console.WriteLine($"   - Cap7dPreviousTs: {token.Cap7dPreviousTs}");
                Console.WriteLine($"   - Name: {token.Name}");
                Console.WriteLine($"   - Price: {token.Price}");
                Console.WriteLine($"   - Symbol: {token.Symbol}");
                Console.WriteLine($"   - Volume: {token.Volume}");
                Console.WriteLine($"   - Volume1dCurrent{token.Volume1dCurrent}");
                Console.WriteLine($"   - Volume1dPrevious: {token.Volume1dPrevious}");
                Console.WriteLine($"   - Volume30dCurrent: {token.Volume30dCurrent}");
                Console.WriteLine($"   - Volume30dPrevious: {token.Volume30dPrevious}");
                Console.WriteLine($"   - Volume7dCurrent: {token.Volume7dCurrent}");
                Console.WriteLine($"   - Volume7dPrevious: {token.Volume7dPrevious}");
            }
            printTotals(response.Totals);
        }

        private static void printTotals(Models.Shared.Totals.Totals totals)
        {
            Console.WriteLine(" - Totals: ");
            Console.WriteLine($"   - Cap: {totals.Cap}");
            Console.WriteLine($"   - CapPrev: {totals.CapPrevious}");
            Console.WriteLine($"   - Tokens: {totals.Tokens}");
            Console.WriteLine($"   - TokensWithPrice: {totals.TokensWithPrice}");
            Console.WriteLine($"   - Ts: {totals.Ts}");
            Console.WriteLine($"   - Volume24h: {totals.Volume24h}");
            Console.WriteLine($"   - VolumePrevius: {totals.VolumePrevious}");
        }

        private static void printGetAddressTransactions(Models.getAddressTransactions.Transaction[] transactions)
        {
            foreach(var transaction in transactions)
            {
                Console.WriteLine($" - From: {transaction.From}");
                Console.WriteLine($" - Hash: {transaction.Hash}");
                Console.WriteLine($" - Input: {transaction.Input}");
                Console.WriteLine($" - Success: {transaction.Success}");
                Console.WriteLine($" - Timestamp: {transaction.Timestamp}");
                Console.WriteLine($" - To: {transaction.To}");
                Console.WriteLine($" - Value: {transaction.Value}");
            }
        }

        private static void printGetAddressHistory(Models.getAddressHistory.Response response)
        {
            foreach (var operation in response.Operations)
                printOperation(operation);
        }

        private static void printGetTokenHistory(Models.getTokenHistory.Response response)
        {
            foreach (var operation in response.Operations)
                printOperation(operation);
        }

        private static void printTxInfo(Models.getTxInfo.Response response)
        {
            Console.WriteLine($" - BlockNumber: {response.BlockNumber}");
            Console.WriteLine($" - Confirmations: {response.Confirmations}");
            Console.WriteLine($" - Creates: {response.Creates}");
            Console.WriteLine($" - From: {response.From}");
            Console.WriteLine($" - GasLimit: {response.GasLimit}");
            Console.WriteLine($" - GasUsed: {response.GasUsed}");
            Console.WriteLine($" - Hash: {response.Hash}");
            Console.WriteLine($" - Input: {response.Input}");
            Console.WriteLine($" - Success: {response.Success}");
            Console.WriteLine($" - Timestamp: {response.Timestamp}");
            Console.WriteLine($" - To: {response.To}");
            Console.WriteLine($" - Value: {response.Value}");
            Console.WriteLine($" - Logs:");
            foreach(var log in response.Logs)
            {
                Console.WriteLine($"   - Address: {log.Address}");
                Console.WriteLine($"   - Data: {log.Data}");
                Console.WriteLine($"   - Topics: {String.Join(", ", log.Topics)}");
            }
            Console.WriteLine($" - Operations:");
            foreach(var operation in response.Operations)
            {
                printOperation(operation);
            }
        }

        private static void printOperation(Models.Shared.Operation.Operation operation)
        {
            Console.WriteLine($" - Addresses: {(operation.Addresses == null ? "NULL" : String.Join(", ", operation.Addresses))}");
            Console.WriteLine($" - From: {operation.From}");
            Console.WriteLine($" - IntValue: {operation.IntValue}");
            Console.WriteLine($" - IsEth: {operation.IsEth}");
            Console.WriteLine($" - Priority: {operation.Priority}");
            Console.WriteLine($" - Timestamp: {operation.Timestamp}");
            Console.WriteLine($" - To: {operation.To}");
            Console.WriteLine($" - Transaction Hash: {operation.TransactionHash}");
            Console.WriteLine($" - Type: {operation.Type}");
            Console.WriteLine($" - UsdPrice: {operation.UsdPrice}");
            Console.WriteLine($" - Value: {operation.Value}");
            Console.WriteLine($" - TokenInfo:");
            printTokenInfo(operation.TokenInfo);
        }

        private static void printGetAddressInfoResponse(Models.getAddressInfo.Response response)
        {
            Console.WriteLine($" - Address: {response.Address}");
            Console.WriteLine($" - ContractInfo:");
            Console.WriteLine($"   - CreatorAddress: {response.ContractInfo.CreatorAddress}");
            Console.WriteLine($"   - Timestamp: {response.ContractInfo.Timestamp}");
            Console.WriteLine($"   - TransactionHash: {response.ContractInfo.TransactionHash}");
            Console.WriteLine($" - ETH:");
            Console.WriteLine($"   - Balance: {response.ETH.Balance}");
            Console.WriteLine($"   - CountTxs: {response.ETH.CountTxs}");
            Console.WriteLine($"   - TotalIn: {response.ETH.TotalIn}");
            Console.WriteLine($"   - TotalOut: {response.ETH.TotalOut}");
            Console.WriteLine($"TokenInfo: ");
            printTokenInfo(response.TokenInfo);
            foreach(var token in response.Tokens)
            {
                Console.WriteLine($"Token:");
                printTokenInfo(token.TokenInfo);
                Console.WriteLine($"   - Balance: {token.Balance}");
                Console.WriteLine($"   - TotalIn: {token.TotalIn}");
                Console.WriteLine($"   - TotalOut: {token.TotalOut}");
            }
        }

        private static void printTokenInfo(TokenInfo input)
        {
            Console.WriteLine($" - Address: {input.Address}");
            Console.WriteLine($" - Coingecko: {input.Coingecko}");
            Console.WriteLine($" - CountOps: {input.CountOps}");
            Console.WriteLine($" - Decimals: {input.Decimals}");
            Console.WriteLine($" - Description: {input.Description}");
            Console.WriteLine($" - EthTransferCount: {input.EthTransferCount}");
            Console.WriteLine($" - Facebook: {input.Facebook}");
            Console.WriteLine($" - HoldersCount: {input.HoldersCount}");
            Console.WriteLine($" - Image: {input.Image}");
            Console.WriteLine($" - IssuancesCount: {input.IssuancesCount}");
            Console.WriteLine($" - LastUpdated: {input.LastUpdated}");
            Console.WriteLine($" - Name: {input.Name}");
            Console.WriteLine($" - Owner: {input.Owner}");
            Console.WriteLine($" - Reddit: {input.Reddit}");
            Console.WriteLine($" - Symbol: {input.Symbol}");
            Console.WriteLine($" - Telegram: {input.Telegram}");
            Console.WriteLine($" - TotalIn: {input.TotalIn}");
            Console.WriteLine($" - TotalOut: {input.TotalOut}");
            Console.WriteLine($" - TotalSupply: {input.TotalSupply}");
            Console.WriteLine($" - TransfersCount: {input.TransfersCount}");
            Console.WriteLine($" - Twitter: {input.Twitter}");
            Console.WriteLine($" - Website: {input.Website}");
            Console.WriteLine($" - Price");
            if (input.Price != null)
            {
                Console.WriteLine($"   - AvailableSupply: {input.Price.AvailableSupply}");
                Console.WriteLine($"   - Currency: {input.Price.Currency}");
                Console.WriteLine($"   - Diff: {input.Price.Diff}");
                Console.WriteLine($"   - Diff30d: {input.Price.Diff30d}");
                Console.WriteLine($"   - Diff7d: {input.Price.Diff7d}");
                Console.WriteLine($"   - MarketCapUsd: {input.Price.MarketCapUsd}");
                Console.WriteLine($"   - OnlyPrice: {input.Price.OnlyPrice}");
                Console.WriteLine($"   - PublicTags: {input.Price.PublicTags}");
                Console.WriteLine($"   - Rate: {input.Price.Rate}");
                Console.WriteLine($"   - Ts: {input.Price.Ts}");
                Console.WriteLine($"   - VolDiff1: {input.Price.VolDiff1}");
                Console.WriteLine($"   - VolDiff30: {input.Price.VolDiff30}");
                Console.WriteLine($"   - VolDiff7: {input.Price.VolDiff7}");
                Console.WriteLine($"   - Volume24h: {input.Price.Volume24h}");
            }
        }
    }
}
