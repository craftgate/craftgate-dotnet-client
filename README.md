# Craftgate .NET Client

[![Build Status](https://github.com/craftgate/craftgate-dotnet-client/actions/workflows/craftgate-dotnet-build.yml/badge.svg?branch=master)](https://github.com/craftgate/craftgate-dotnet-client/actions?query=branch%3Amaster)
[![NuGet](https://img.shields.io/nuget/v/Craftgate.svg)](https://www.nuget.org/packages/Craftgate/)
[![Gitpod ready-to-code](https://img.shields.io/badge/Gitpod-ready--to--code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/craftgate/craftgate-dotnet-client)

This repo contains the Dotnet client for Craftgate API.

[![Open in Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://gitpod.io/#https://github.com/craftgate/craftgate-dotnet-client)

## Requirements
- .NET Framework 4.5+
- .NET Core 1.0+ and .NET 5+ (through .NET Standard 1.3 and 2.0)

## Installation
```bash
Install-Package Craftgate
```

## Usage
To access the Craftgate API you'll first need to obtain API credentials (e.g. an API key and a secret key). If you don't already have a Craftgate account, you can signup at [https://craftgate.io/](https://craftgate.io)

Once you've obtained your API credentials, you can start using Craftgate by instantiating a `Craftgate` with your credentials.

```csharp

CraftgateClient _craftgate = new CraftgateClient("<YOUR API KEY>", "<YOUR SECRET KEY>");
...

```

By default the Craftgate client connects to the production API servers at `https://api.craftgate.io`. For testing purposes, please use the sandbox URL `https://sandbox-api.craftgate.io`

```csharp

CraftgateClient _craftgate = new CraftgateClient("<YOUR API KEY>", "<YOUR SECRET KEY>", "https://sandbox-api.craftgate.io");
...

```

## Examples
Included in the project are a number of examples that cover almost all use-cases. Refer to [the `Samples/` folder](./Samples) for more info.

### Running the Examples
If you've cloned this repo on your development machine and wish to run the examples, replace the `api-key` and `secret-key` values in the sample class with your sandbox credentials, then run the samples against the sandbox API with `dotnet test Samples`, or a single one with:

```bash
dotnet test Samples --filter "FullyQualifiedName=Samples.PaymentSample.Create_Payment"
```

To run only the unit tests, which don't call the Craftgate API, use `dotnet test Test`.

### Credit Card Payment Use Case
Let's quickly review an example where we implement a credit card payment scenario.

> For more examples covering almost all use-cases, check out the [examples in the `Samples/` folder](./Samples)

```csharp
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

## Idempotency

Mutating operations accept an optional idempotency key. Set it on the request object and the client sends it as the `x-idempotency-key` header, so a request can be safely retried (e.g. after a timeout) without the operation being performed twice — the server returns the result of the first request when it sees a repeated key.

Every request extends `BaseRequest`, which carries a `HeaderOptions` object, so the key is available on any request:

```csharp
var request = new CreatePaymentRequest
{
    Price = new decimal(100.0),
    PaidPrice = new decimal(100.0),
    Currency = Currency.Try,
    PaymentGroup = PaymentGroup.ListingOrSubscription,
    HeaderOptions = new HeaderOptions {IdempotencyKey = Guid.NewGuid().ToString()},
    // ... other fields
};

var response = _craftgate.Payment().CreatePayment(request);
```

Operations whose parameters live in the URL path take a request object as well, so they can carry a key too:

```csharp
_craftgate.Payment().ExpireCheckoutPayment(new ExpireCheckoutPaymentRequest
{
    Token = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
    HeaderOptions = new HeaderOptions {IdempotencyKey = Guid.NewGuid().ToString()}
});
```

> Use a fresh key per distinct operation, and reuse the same key when retrying that operation.

> The API honours the key on `POST`, `PATCH` and `DELETE` only. It is ignored on `PUT` endpoints, so retrying one of those is not de-duplicated.

`HeaderOptions` is sent as headers only — it never appears in the request body, the query string, or the request signature.

### Contributions
For all contributions to this client please see the contribution guide [here](CONTRIBUTING.md). By participating in this project, you agree to abide by our [Code of Conduct](CODE_OF_CONDUCT.md).

## Security
If you discover a security vulnerability, please review our [Security Policy](SECURITY.md) for how to report it responsibly.

## License
This project is licensed under the Apache License, Version 2.0 — see the [LICENSE](LICENSE) and [NOTICE](NOTICE.md) files for details.
