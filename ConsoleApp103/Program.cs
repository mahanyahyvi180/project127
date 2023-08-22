using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp103
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int number = 1; number <= 20; number += 2)
            {
                total += number;
            }
            Console.WriteLine($"sum is{total}");
            Console.ReadLine();
        }
    }
}
