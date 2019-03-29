using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestClass
    {
        public string str { get; set; }

        public int wiek { get; set; }
        
        private int rok;

        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }


        public void go()
        {
            Console.WriteLine("TestClass");
        }
    }
}
