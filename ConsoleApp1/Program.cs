using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var multiplyedMoreThanFive = testArray
                .Where(item => item > 5)
                .Select(item => item * 1000);

            foreach (var item in multiplyedMoreThanFive)
                Console.WriteLine(item);
            

            Console.WriteLine("Hello World!");
        }
    }
}
