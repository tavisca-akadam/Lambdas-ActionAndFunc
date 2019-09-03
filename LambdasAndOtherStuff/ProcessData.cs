using System;

namespace LambdasAndOtherStuff
{
    public class ProcessData
    {
        public void Process(int x, int y, BizRuleDelegate del)
        {
            int result = del(x, y);
            Console.WriteLine($"Result = {result}");
        }

    }
}
