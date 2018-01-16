# Coinbase.Net SDK
Coinbase.Net SDK is a Coinbase .NET Client library which implemented APIs listed by https://developers.coinbase.com/api/v2. 

[![Nuget](https://img.shields.io/nuget/v/Coinbase.NetSDK.svg)](https://www.nuget.org/packages/Coinbase.NetSDK/) [![Users](https://img.shields.io/nuget/dt/Coinbase.NetSDK.svg)](https://www.nuget.org/packages/Coinbase.NetSDK/)

## Get started
### How to install
````sh
Install-Package Coinbase.NetSDK
````

#### How to use
* Send Money

````cs
using Coinbase.Wallet;

public static void Main(string[] args)
{
	var client = new Client("apiKey", "apiSecret");
    var account = client.GetPrimaryAccount();

    var transaction = client.SendMoney(account.Id, new TransactionSendModel {
    	To = "1rundZJCMJhUiWQNFS5uT3BvisBuLxkAp",
        Amount = 0.0001M,
        Currency = CurrencyType.BTC
    });
}

````

#### Tip Jar
* **Bitcoin**: `1BduuiXQpjKbtqGB3z9ejELxG4zNJDXAKb`
* **Litecoin**: `LVquexz6NSZsvCT3ckKnSGSDXtHzXKDPeB`
* **Ethereum**: `0xc8b1293d1b8Cba5c03e4edb0a091074d99ec4d6D`

## Reference
* [Coinbase API Documentation](https://developers.coinbase.com/api/v2)

