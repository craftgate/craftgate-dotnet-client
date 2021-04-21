# Craftgate .NET Client

![Craftgate Dotnet CI](https://github.com/craftgate/craftgate-dotnet-client/workflows/Craftgate%20Dotnet%20CI/badge.svg?branch=master)
[![NuGet](https://img.shields.io/nuget/v/Craftgate.svg)](https://www.nuget.org/packages/Craftgate/)

This repo contains the Dotnet client for Craftgate API.

## Requirements
- .NET Framework 4.6+
- .NET Core 1.1+ 
- .NET Core 2.0+

## Installation
```bash
Install-Package Craftgate
```

## Usage
To access the Craftgate API you'll first need to obtain API credentials (e.g. an API key and a secret key). If you don't already have a Craftgate account, you can signup at [https://craftgate.io/](https://craftgate.io)

Once you've obtained your API credentials, you can start using Craftgate by instantiating a `Craftgate` with your credentials.

```dotnet

CraftgateClient _craftgate = new CraftgateClient("<YOUR API KEY>", "<YOUR SECRET KEY>");
...

```

By default the Craftgate client connects to the production API servers at `https://api.craftgate.io`. For testing purposes, please use the sandbox URL `https://sandbox-api.craftgate.io` using the .

```dotnet

CraftgateClient _craftgate = new CraftgateClient("<YOUR API KEY>", "<YOUR SECRET KEY>", "https://sandbox-api.craftgate.io");
...

```

## Examples
Included in the project are a number of examples that cover almost all use-cases. Refer to [the `Samples/` folder](./Samples)] for more info.

### Running the Examples
If you've cloned this repo on your development machine and wish to run the examples you can run an example with the command `dotnet test` or run single test with the command `dotnet test --filter Name~Create_Payment`

### Credit Card Payment Use Case
Let's quickly review an example where we implement a credit card payment scenario.

> For more examples covering almost all use-cases, check out the [examples in the `Samples/` folder](./Samples)

```dotnet
CraftgateClient _craftgate = new CraftgateClient("<YOUR API KEY>", "<YOUR SECRET KEY>");

var request = new CreatePaymentRequest
{
    Price = new decimal(100.0),
    PaidPrice = new decimal(100.0),
    WalletPrice = new decimal(0.0),
    Installment = 1,
    ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
    Currency = Currency.Try,
    PaymentGroup = PaymentGroup.ListingOrSubscription,
    Card = new CardDto
    {
        CardHolderName = "Haluk Demir",
        CardNumber = "5258640000000001",
        ExpireYear = "2044",
        ExpireMonth = "07",
        Cvc = "000"
    },
    Items = new List<PaymentItem>
    {
        new PaymentItem
        {
            Name = "Item 1",
            Price = new decimal(30.0),
            ExternalId = "externalId-1"
        },
        new PaymentItem
        {
            Name = "Item 2",
            Price = new decimal(50.0)
        },
        new PaymentItem
        {
            Name = "Item 3",
            Price = new decimal(20.0),
            ExternalId = "externalId-3"
        }
    }
};

var response = _craftgate.Payment().CreatePayment(request);
Assert.NotNull(response);
```

### Advanced Usage: Adapters
In reality, the `Craftgate` class serves as a collection of adapters that integrates with different parts of the API. While the intended usage for most use-cases is to instantiate a `Craftgate` instance (as illustrated in the examples above) and use its adapter accessors (e.g. `payment()`), you can also manually import a certain adapter class and instantiate it.

**Note:** When instantiating an adapter, you can use the same options as you would when instantiating a `Craftgate`

For all adapters in the `Craftgate`, their purposes, accessors, as well as direct import paths, refer to the list below:

| Adapter Name | Purpose | Accessor |
|--------------|---------|----------|
| `InstallmentAdapter` | Retrieving per-installment pricing information based on installment count or BIN number | `Installment()` |
| `OnboardingAdapter` | Conducting CRUD operations on members like buyers and submerchants | `Onboarding()` |
| `PaymentAdapter` | Conducting payments, retrieving payment information, managing stored cards | `Payment()` |
| `WalletAdapter` | Wallet operations like send, receive remittance and search wallets or wallet transactions of member's   | `Wallet()` |
| `SettlementReportingAdapter` | Settlement operations like search payout completed transactions, search bounced payout transactions | `SettlementReporting()` |

### Contributions
For all contributions to this client please see the contribution guide [here](CONTRIBUTING.md).

## License
MIT
