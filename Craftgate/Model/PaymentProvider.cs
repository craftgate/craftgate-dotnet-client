﻿using System.Runtime.Serialization;

namespace Craftgate.Model
{
    public enum PaymentProvider
    {
        [EnumMember(Value = "BANK")] BANK,
        [EnumMember(Value = "CG_WALLET")] CG_WALLET,
        [EnumMember(Value = "MASTERPASS")] MASTERPASS,
        [EnumMember(Value = "GARANTI_PAY")] GARANTI_PAY,
    }
}