using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test = "Hello World!";

            test = test.ToUpper();

            Console.WriteLine(test);
            
            var testClass = new Test(test);
        }
    }

    public class Test
    {
        public Test(string name)
        {
            var a = name;
        }
    }
}
