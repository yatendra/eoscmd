using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class CurrencyBalanceArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Account name"), ArgPosition(2)]
        public string account { get; set; }
        [ArgRequired, ArgDescription("Contract name"), ArgPosition(3)]
        public string code { get; set; }
        [ArgRequired, ArgDescription("Currency symbol"), ArgPosition(4)]
        public string symbol { get; set; }
    }
}
