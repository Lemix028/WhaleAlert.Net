# WhaleAlert.Net
A lightweight .NET API libary for Whale Alert API. 


### Features

- All features from the [Whale Alert API](https://docs.whale-alert.io/) are included. 



### Installation
![Nuget version](https://img.shields.io/nuget/v/whalealert.net.svg)  ![Nuget downloads](https://img.shields.io/nuget/dt/whalealert.net.svg)

Available on [Nuget](https://www.nuget.org/packages/WhaleAlert.NET/)
> npm install WhaleAlert.NET



### How to use

```csharp

WhaleAlert whaleAlert = new WhaleAlert("ABCDEFGH");
StatusResponse Status = whaleAlert.GetStatus();
TransactionResponse transactionResponse = whaleAlert.GetTransaction("ethereum", "0015286d8642f0e0553b7fefa1c168787ae71173cbf82ec2f2a1b2e0ffee72b2");
TransactionsResponse transactionsResponse = whaleAlert.GetTransactions(1550237797);

 ```
