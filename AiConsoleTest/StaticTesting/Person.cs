using System;
using System.Collections.Generic;
using System.Text;

namespace AiConsoleTest
{
    public class Person //static keyword test
    {
        public static string name = "staticName";

        public string pname { get; set; }

        static Person()
        {
            Console.WriteLine("Static Block Working");
            Console.WriteLine(name);
        }

        public Person()
        {
            Console.WriteLine("Construtor working");
        }
    }
}
