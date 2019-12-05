using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = System.Environment.GetEnvironmentVariable("FOO");
            if (!String.IsNullOrEmpty(value))
            {
                Console.WriteLine(value);
            } else
            {
                Console.WriteLine("No FOO defined");
            }
            Console.ReadLine();
        }
    }
}
