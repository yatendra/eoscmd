using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class TableRowsArguments : BaseArguments
    {
        [ArgRequired, ArgDescription("Contract name"), ArgPosition(2)]
        public string code { get; set; }

        [ArgRequired, ArgDescription("Scope"), ArgPosition(3)]
        public string scope { get; set; }

        [ArgRequired, ArgDescription("Table name "), ArgPosition(4)]
        public string table { get; set; }

        [ArgRequired, ArgDescription("Lower bound "), ArgPosition(5), ArgDefaultValue(0)]
        public int lower_bound { get; set; }

        [ArgRequired, ArgDescription("Limit "), ArgPosition(6), ArgDefaultValue(10)]
        public int limit { get; set; }

        [ArgDescription("Upper bound "), ArgPosition(7), ArgDefaultValue(-1)]
        public int upper_bound { get; set; }
    }
}
