using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class AccountArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Account name"), ArgPosition(2)]
        public string account_name { get; set; }
    }
}
