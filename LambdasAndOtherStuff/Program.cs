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

            //Using Action<T>
            var actionDemo = new ActionDemo();
            actionDemo.DoAction();



            Console.ReadKey(true);

        }
        protected static void AddNumberHandler(int num1, int num2)
        {
            Console.WriteLine($"result = {num1 + num2}");
        }
    }

    public class ActionDemo
    {
        public void DoAction()
        {
            Action<int, int> addAction = (x, y) => Console.WriteLine($"Result of Add Action {x + y}");
            Action<int, int> multiplyAction = (x, y) => Console.WriteLine($"Result of Multiply Action {x * y}");

            var process = new ProcessData();
            process.ProcessAction(10, 20, addAction);
            process.ProcessAction(2, 4, multiplyAction);
        }
    }
}
