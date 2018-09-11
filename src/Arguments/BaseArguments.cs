using System;
using PowerArgs;

namespace eoscmd.Arguments
{
    public class BaseArguments
    {
        [StickyArg]
        [ArgRequired, ArgDescription("URL of the API that will be queried. This is a sticky param and will be remembered after you've used it once."), ArgPosition(1)]
        public Uri host { get; set; }
    }
}
