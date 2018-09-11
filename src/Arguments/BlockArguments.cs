using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class BlockArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Block number or id"), ArgPosition(2)]
        public string block_num_or_id { get; set; }
    }
}
