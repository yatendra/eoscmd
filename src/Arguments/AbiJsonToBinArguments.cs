using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class AbiJsonToBinArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Contract name"), ArgPosition(2)]
        public string code { get; set; }

        [ArgRequired, ArgDescription("Action name"), ArgPosition(3)]
        public string action { get; set; }

        [ArgRequired, ArgDescription("Json arguments "), ArgPosition(4)]
        public string args { get; set; }
    }
}
