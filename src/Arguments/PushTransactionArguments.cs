using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class PushTransactionArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Actions as json array"), ArgPosition(2)]
        public string actions { get; set; }
        [ArgRequired, ArgDescription("Private keys in WIF format as json array"), ArgPosition(3)]
        public string private_keys { get; set; }
    }
}
