using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3 ---- https://www.w3resource.com/
            // Divide two numbers

            // Direct division of two numbers
            //Console.WriteLine(18 / 4);

            // Division of two numbers given by the user
            Console.Write("Give a = ");
            int a = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("Give b different from 0.");
            Console.Write("b = ");
            int b = System.Int32.Parse(Console.ReadLine());

            try
            {
                int div = a / b;
                Console.WriteLine("{0} / {1} = {2}", a, b, div);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }         
        }
    }
}
