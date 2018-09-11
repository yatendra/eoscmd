using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class CodeArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Account name"), ArgPosition(2)]
        public string account_name { get; set; }
        [ArgRequired, ArgDescription("Code as wasm"), ArgPosition(3)]
        public bool code_as_wasm { get; set; }
    }
}
