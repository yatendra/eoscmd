using System;
using PowerArgs;

namespace eoscmd
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                args = new [] { "-?" };
            }
            Args.InvokeAction<EOSCmd>(args);
        }
    }
}
