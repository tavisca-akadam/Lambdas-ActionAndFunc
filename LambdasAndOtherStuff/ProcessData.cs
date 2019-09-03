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

        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);

            Console.WriteLine("Procesing Action");
        }

        public void ProcessFunc(int x, int y, Func<int, int, int> func)
        {
            int result = func(x, y);
            Console.WriteLine($"result = {result}");
        }
    }
}
