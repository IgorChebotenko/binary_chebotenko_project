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
        public void TestLogic(int number)
        {
            int sum = 0;
            while(number!=0)
            {
                sum += number % 10;
                number /= 10;
               
            }
            Console.WriteLine("The sum of digits={0}", sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Test1();
            test.Test2();
            test.TestLogic(123);


        }
    }
}
