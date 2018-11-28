using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2 ---- https://www.w3resource.com/
            // Compute the sum of two given integers
            
            Console.Write("a = ");
            int a = System.Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = System.Int32.Parse(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine("a + b = {0}", sum);  
        }
    }
}
