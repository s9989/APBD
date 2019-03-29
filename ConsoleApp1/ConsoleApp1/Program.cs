using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestClass tc = new TestClass();
            var tc = new TestClass(); // var - alias

            tc.go();

            

            var st = new TestClass
            {
                str = "str"
            };

            Console.WriteLine("Hello World!");
        }
    }
}
