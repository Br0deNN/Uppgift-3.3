using System;
using System.Diagnostics.CodeAnalysis;

namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            string h = Console.ReadLine();

            int timmar = int.Parse(h);

            int sum = timmar * 80;

            if (sum > 950)
            {
                Console.WriteLine("Det kostar 950 kr");
            }

            else
            {
                Console.WriteLine("Det kostar "+ sum + " kr");
            }
            Console.ReadKey();
        }
    }
}
