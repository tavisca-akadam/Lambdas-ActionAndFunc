using System;

namespace LambdasAndOtherStuff
{

    public delegate int BizRuleDelegate(int a, int b);
    public delegate void AddNumber(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Without Lambda
            AddNumber del = new AddNumber(AddNumberHandler);
            del(10, 20);

            //With Lambda 
            AddNumber add = (a, b) => Console.WriteLine($"result = {a + b}");
            add(1, 3);


            BizRuleDelegate addRule = (x, y) => x + y;
            BizRuleDelegate multiplyRule = (x, y) => x * y;

            var data = new ProcessData();
            data.Process(10, 20, addRule);
            data.Process(2, 4, multiplyRule);

            

            Console.ReadKey(true);

        }
        protected static void AddNumberHandler(int num1, int num2)
        {
            Console.WriteLine($"result = {num1 + num2}");
        }
    }
   
}
