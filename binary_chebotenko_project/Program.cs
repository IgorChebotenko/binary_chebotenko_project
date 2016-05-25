using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_chebotenko_project
{
    class Test
    {
        public void Test1()
        {
            Console.WriteLine("Hello!");
        }
        public void Test2()
        {
            Console.WriteLine("Binary");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Test1();
            test.Test2();
        }
    }
}
