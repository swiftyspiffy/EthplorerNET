# EthplorerNET

## About
EthplorerNET is a C# .NET Standard library that has implemented all of the public facing [Ethplorer](https://ethplorer.io/) [API's](https://github.com/EverexIO/Ethplorer/wiki/Ethplorer-API). By default, the library will use the `freeapi` API key, which allows a decent amount of API access. You can register on Ethplorer and get your own API key, which will increase your rate limits. Keep in mind, this library is optimistic about what is returned from the API, meaning it wont throw exceptions on missing or invalid types. You should check for nulls on values you're accessing before using them :).

The list of API's are:
- GetLastBlock()
- GetTokenInfo()
- GetAddressInfo()
- GetTxInfo()
- GetTokenHistory()
- GetAddressHistory()
- GetAddressTransactions()
- GetTop()
- GetTopTokens()
- GetTokenHistoryGrouped()
- GetTokenPriceHistoryGrouped()

## Example Usage
Client instantiation:
```
var api = new EthplorerNET.Api(); // default api key is freekey
```
```
var api = new EthplorerNET.Api("my-api-key");
```
Get a wallet's balance:
```
var walletAddress = "0xd9cfab54f1234aeea22b2818ab919866a2809c1c";
var getAddressInfoResponse = api.GetAddressInfo(new Models.getAddressInfo.Input
{
    Address = walletAddress
}).GetAwaiter().GetResult();

Console.WriteLine($"Information for: {walletAddress}");
Console.WriteLine($" - Eth equivalent: {getAddressInfoResponse.ETH.Balance}");
Console.WriteLine($" - Tokens ({getAddressInfoResponse.Tokens.Length}):");
foreach(var token in getAddressInfoResponse.Tokens)
{
    Console.WriteLine($"  - {token.TokenInfo.Name} ({token.TokenInfo.Symbol})");
    Console.WriteLine($"    - Balance: {token.Balance}");
}
```
```
Information for: 0xd9cfab54f1234aeea22b2818ab919866a2809c1c
 - Eth equivalent: 52.99718906000281
 - Tokens (113):
  - Cowboy.Finance (MILK)
    - Balance: 3.139241659E+20
  - Sifchain (EROWAN)
    - Balance: 1.5686073991849998E+22
  -  ()
    - Balance: 1.6668456E+23
  - 1inch (1INCH)
    - Balance: 8.538702060717207E+17
  - Insured Finance (INFI)
    - Balance: 1E+22
  - Farming: 1inch Liquidity Pool (ETH-OPIUM) (farm-1LP-ETH-OPIUM)
    - Balance: 1.0385103265609548E+20
  - Vesper Finance (VSP)
    - Balance: 1.6607405028735196E+18
 . . .
```

Get a token's value:
```
var getTokenInfoResponse = api.GetTokenInfo(new Models.getTokenInfo.Input
{
    Address = "0x41d5d79431a913c4ae7d69a668ecdfe5ff9dfb68"
}).GetAwaiter().GetResult();
Console.WriteLine($"Information for token: {getTokenInfoResponse.Address}");
Console.WriteLine($" - {getTokenInfoResponse.Name} ({getTokenInfoResponse.Symbol})");
Console.WriteLine($" - Price: {getTokenInfoResponse.Price.Rate} (Currency: {getTokenInfoResponse.Price.Currency})");
Console.WriteLine($" - Diff: {getTokenInfoResponse.Price.Diff}, diff7d: {getTokenInfoResponse.Price.Diff7d}, diff30d: {getTokenInfoResponse.Price.Diff30d}");
Console.WriteLine($" - CountOps: {getTokenInfoResponse.CountOps}");
Console.WriteLine($" - Decimals: {getTokenInfoResponse.Decimals}");
```
```
Information for token: 0x41d5d79431a913c4ae7d69a668ecdfe5ff9dfb68
 - Inverse DAO (INV)
 - Price: 1351.9632612040007 (Currency: USD)
 - Diff: 6.3, diff7d: 44.39, diff30d: 0
 - CountOps: 22774
 - Decimals: 18
```
Get a transaction's state:
```
var getTxInfoResponse = api.GetTxInfo(new Models.getTxInfo.Input
{
    TransactionHash = "0x6aa670c983425eba23314459c48ae89b3b8d0e1089397c56400ce2da5ece9d26"
}).GetAwaiter().GetResult();
Console.WriteLine($"Information on transaction hash: {getTxInfoResponse.Hash}");
Console.WriteLine($" - Block Number: {getTxInfoResponse.BlockNumber}");
Console.WriteLine($" - Gas used: {getTxInfoResponse.GasUsed}, Gas limit: {getTxInfoResponse.GasLimit}");
Console.WriteLine($" - Successful: {getTxInfoResponse.Success}");
Console.WriteLine($" - Operations:");
foreach (var operation in getTxInfoResponse.Operations)
{
    Console.WriteLine($"   - From: {operation.From}");
    Console.WriteLine($"   - To: {operation.To}");
    Console.WriteLine($"   - Value: {operation.Value} (USD: {operation.UsdPrice})");
}
```
```
Information on transaction hash: 0x6aa670c983425eba23314459c48ae89b3b8d0e1089397c56400ce2da5ece9d26
 - Block Number: 2804997
 - Gas used: 58128, Gas limit: 180000
 - Successful: True
 - Operations:
   - From: 0x0347c7fe704384c7e32073d35b7661788e7071ff
   - To: 0x06758b9a8a7970e59f7e6487f80f4cb1069df878
   - Value: 50000 (USD: 0.028043505572805424)
```

## Testing
Included in this repository is a Test project that exercises all API calls, and prints out all associated data in their modeled responses. This is also good for example usage. You can find the directory here: https://github.com/swiftyspiffy/EthplorerNET/tree/main/EthplorerNET.Test

## NuGet
The package is available on [NuGet](https://www.nuget.org/packages/EthplorerNET) under the name `EthplorerNET`. You can either search for it in the VS NuGet explorer, you use the install command:
```
Install-Package EthplorerNET
```

## License
This project is available under the MIT license.

## Credits
- [Ethplorer.io](https://ethplorer.io): Solid API
- [Netonsoft.Json](https://www.newtonsoft.com/json): JSON serializing and deserializing


