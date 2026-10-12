using System;

namespace Craftgate.Model
{
    public class LoyaltyData
    {
        public int MaxPostponingPaymentCount { get; set; }
        public int MinPostponingPaymentCount { get; set; }
        public LoyaltyUnitType UnitType { get; set; }
        public bool DeferredPaymentEligible { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public string DueDateShiftDirection { get; set; }
        public decimal SingleTotalDueDateDayCount { get; set; }
        public string Code { get; set; }
    }
}