using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class PushActionArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Account name"), ArgPosition(2)]
        public string account { get; set; }
        [ArgRequired, ArgDescription("Action name"), ArgPosition(3)]
        public string action { get; set; }
        [ArgRequired, ArgDescription("Permission actor"), ArgPosition(4)]
        public string permission_actor { get; set; }
        [ArgRequired, ArgDescription("Permission name"), ArgPosition(5)]
        public string permission_name { get; set; }
        [ArgRequired, ArgDescription("Contract name"), ArgPosition(6)]
        public string code { get; set; }
        [ArgRequired, ArgDescription("Action arguments json string"), ArgPosition(7)]
        public string args { get; set; }
        [ArgRequired, ArgDescription("Private keys in WIF format as json array"), ArgPosition(8), ArgShortcut("pk")]
        public string private_keys { get; set; }
    }
}
