using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class AbiBinToJsonArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Contract name"), ArgPosition(2)]
        public string code { get; set; }

        [ArgRequired, ArgDescription("Action name"), ArgPosition(3)]
        public string action { get; set; }

        [ArgRequired, ArgDescription("Binary arguments"), ArgPosition(4)]
        public string binargs { get; set; }
    }
}
