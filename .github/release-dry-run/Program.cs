using System;
using System.Collections.Generic;
using Craftgate.Adapter;
using Craftgate.Request;
using Craftgate.Request.Common;

public class ProbeAdapter : BaseAdapter
{
    public ProbeAdapter(RequestOptions options) : base(options) { }
    public Dictionary<string, string> Headers(RequestOptions options) =>
        CreateHeaders(new DeleteStoredCardRequest {CardToken = "card-token"}, "/payment/v1/cards/delete", options);
}

public static class Program
{
    public static int Main(string[] args)
    {
        var options = new RequestOptions {ApiKey = "api-key", SecretKey = "secret-key", BaseUrl = "https://sandbox-api.craftgate.io"};
        var actual = new ProbeAdapter(options).Headers(options)["x-client-version"];
        var expected = "craftgate-dotnet-client:" + args[0];
        Console.WriteLine((actual == expected ? "OK " : "FAIL ") + actual);
        return actual == expected ? 0 : 1;
    }
}
